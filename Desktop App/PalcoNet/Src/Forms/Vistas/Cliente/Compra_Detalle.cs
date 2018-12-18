using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra_Detalle : Master
    {
        private Publicacion publicacion;
        private Src.Modelo.Entidades.Cliente cliente;
        private Compra_Ubicacion form_ubicacion;
        private Compra_Sin_Numerar form_compraSN;
        private double precioTotal = 0.0;
        private List<Entrada> entradasCompradasN = new List<Entrada>();
        private List<Entrada> entradasCompradasSN = new List<Entrada>();

        SortableBindingList<Entrada> entradasDisponiblesN = null;
        SortableBindingList<Entrada> entradasDisponiblesSN = null;


        public Compra_Detalle(Form anterior, Usuario usuario,Publicacion publicacion)
        {
            this.previous = anterior;
            this.publicacion = publicacion;

            this.loadCliente(usuario);

            InitializeComponent();
        }

        private void Compra_Detalle_Load(object sender, EventArgs e)
        {
            this.label_espectaculo.Text = publicacion.Descripcion;
            this.label_fecha.Text = publicacion.FechaEvento.ToString();
            this.label_nombre.Text = this.cliente.Nombre;
            this.label_apellido.Text = this.cliente.Apellido;
            this.label_mail.Text = this.cliente.Email;

            if (this.cliente.Email != null)
                this.label_tarjeta.Text = this.cliente.DatosTarjeta;
            else
                this.label_tarjeta.Text = "No hay tarjeta registrada.";

            this.loadEntradas();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if( this.form_ubicacion != null)
                this.form_ubicacion.Close();
            if (this.form_compraSN != null)
                this.form_compraSN.Close();
            this.previous.Show();
            this.Close();
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {

            if(hayEntradas(this.entradasDisponiblesN))
                this.form_ubicacion.ShowDialog();
            else
                MessageBox.Show("No hay más ubicaciones disponibles!", "Listado de ubicaciones.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public void load_entradas()
        {
            this.dataGridEntradasNumeradas.DataSource = null;
            this.dataGridEntradasNumeradas.DataSource = this.entradasCompradasN;

            this.mostrarMontoTotal();

            List<string> encabezados = new List<string>(new string[] { "TipoId", "Id", "Compra", "UbicacionId", "cantSinNumerar", "sinNumerar" });

            foreach (DataGridViewColumn column in this.dataGridEntradasNumeradas.Columns)
            {
                if (encabezados.Contains(column.HeaderText))
                    column.Visible = false;
            }

            this.dataGridEntradasNumeradas.AutoSize = false;
            this.dataGridEntradasNumeradas.ScrollBars = ScrollBars.Both;
            this.dataGridEntradasNumeradas.ClearSelection();
        }

        public void load_entradasSN()
        {
            this.dataGridEntradasSinNumerar.DataSource = null;
            this.dataGridEntradasSinNumerar.DataSource = this.entradasCompradasSN;

            this.mostrarMontoTotal();

            List<string> encabezados = new List<string>(new string[] { "TipoId", "Id", "Compra", "UbicacionId", "Fila", "Asiento", "sinNumerar" });

            foreach (DataGridViewColumn column in this.dataGridEntradasSinNumerar.Columns)
            {
                if (encabezados.Contains(column.HeaderText))
                    column.Visible = false;
            }

            this.dataGridEntradasSinNumerar.AutoSize = false;
            this.dataGridEntradasSinNumerar.ScrollBars = ScrollBars.Both;
            this.dataGridEntradasSinNumerar.ClearSelection();
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            if (this.dataGridEntradasNumeradas.SelectedRows.Count != 0 || this.dataGridEntradasNumeradas.CurrentRow != null)
            {
                Entrada entrada = (Entrada)this.dataGridEntradasNumeradas.CurrentRow.DataBoundItem;
                this.entradasCompradasN.Remove(entrada);
                this.load_entradas();
                this.form_ubicacion.regresarEntrada(entrada);
            }
            else if (this.dataGridEntradasSinNumerar.SelectedRows.Count != 0 || this.dataGridEntradasSinNumerar.CurrentRow != null)
            {
                Entrada entrada = (Entrada)this.dataGridEntradasSinNumerar.CurrentRow.DataBoundItem;
                this.entradasCompradasSN.Remove(entrada);
                entrada.Ocupados -= entrada.cantSinNumerar;
                entrada.cantSinNumerar = 0;
                this.load_entradasSN();
            }
            else
                 MessageBox.Show("Debe seleccionar una ubicación!", "Listado de ubicaciones.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.dataGridEntradasNumeradas.ClearSelection();
        }

        private void mostrarMontoTotal()
        {
            this.precioTotal = 0.0;

            if (this.entradasCompradasN.Count > 0)
            {
                foreach (Entrada entrada in this.entradasCompradasN)
                {
                    precioTotal += entrada.Precio;
                }
            }

            if (this.entradasCompradasSN.Count > 0)
            {
                foreach (Entrada entrada in this.entradasCompradasSN)
                {
                    precioTotal += entrada.Precio*entrada.cantSinNumerar;
                }
            }

            this.label_total.Text = precioTotal.ToString();
        }

        private void loadCliente(Usuario usuario)
        {
            ClienteService clienteService = (ClienteService)ServiceFactory.GetService("Cliente");
            this.cliente = clienteService.GetClienteByUsername(usuario.Username);

        }

        private void btn_confirmar_compra_Click(object sender, EventArgs e)
        {
            if(this.entradasCompradasN.Count == 0)
                MessageBox.Show("Debes elegir al menos una ubicación!", "Error compra.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (this.cliente.DatosTarjeta == "Sin información")
            {
                MessageBox.Show("Debes ingresar una tarjeta!", "Error compra.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Compra_Agregar_Tarjeta tarjeta = new Compra_Agregar_Tarjeta(this, this.cliente);
                tarjeta.ShowDialog();
            }
            else
            {
                DialogResult result = MessageBox.Show("Confirmar compra","Compra",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        List<Entrada> entradasTotal = new List<Entrada>();
                        entradasTotal.AddRange(entradasCompradasN);
                        entradasTotal.AddRange(entradasCompradasSN);
                        CompraService compraService = (CompraService)ServiceFactory.GetService("Compra");
                        compraService.save(this.cliente, entradasTotal, this.precioTotal, this.publicacion);
                        MessageBox.Show("Compra realizada con exito!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form_ubicacion.Close();
                        form_compraSN.Close();
                        this.previous.Show();
                        this.Close();
                    }
                    catch (SqlException exception)
                    {
                        Console.WriteLine(exception.Message);

                        MessageBox.Show(exception.Message, "Error al comprar.",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btn_seleccionSN_Click(object sender, EventArgs e)
        {

            if (hayEntradas(this.entradasDisponiblesSN))
                this.form_compraSN.ShowDialog();
            else
                MessageBox.Show("No hay más ubicaciones disponibles!", "Listado de ubicaciones.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void loadEntradas()
        {
            EntradaService entradaService = new EntradaService();
            List<Entrada> listaCompleta = entradaService.GetAllEntradasDisponibles(this.publicacion.Codigo);

            this.entradasDisponiblesN = new SortableBindingList<Entrada>(listaCompleta.FindAll(e => !e.sinNumerar));

            this.entradasDisponiblesSN = new SortableBindingList<Entrada>(listaCompleta.FindAll(e => e.sinNumerar));

            if (hayEntradas(entradasDisponiblesN))
            {
                Compra_Ubicacion compra_ubicacion = new Compra_Ubicacion(this, publicacion.Codigo, entradasCompradasN, this.entradasDisponiblesN);
                this.form_ubicacion = compra_ubicacion;
            }

            if (hayEntradas(entradasDisponiblesSN))
            {
                Compra_Sin_Numerar form_compraSN = new Compra_Sin_Numerar(this, publicacion.Codigo, this.entradasCompradasSN, this.entradasDisponiblesSN);
                this.form_compraSN = form_compraSN;
            }
        }

        private bool hayEntradas(SortableBindingList<Entrada> entradas)
        {
            return entradas == null || entradas.Count > 0;
        }

        public void setTarjeta()
        {
            this.label_tarjeta.Text = this.cliente.DatosTarjeta;
        }
    }
}
