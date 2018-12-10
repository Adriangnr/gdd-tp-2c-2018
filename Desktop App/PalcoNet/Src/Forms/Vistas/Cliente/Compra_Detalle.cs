using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;
using System.Data;
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
        List<Entrada> entradasCompradas = new List<Entrada>();

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
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.form_ubicacion.Close();
            this.previous.Show();
            this.Close();
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {
            if (this.form_ubicacion == null)
            {
                Compra_Ubicacion compra_ubicacion = new Compra_Ubicacion(this, publicacion.Codigo, entradasCompradas);
                this.form_ubicacion = compra_ubicacion;
                compra_ubicacion.ShowDialog();
            }
            else
                this.form_ubicacion.ShowDialog();
            
        }

        public void load_entradas()
        {
            this.dataGridEntradasCompradas.DataSource = null;
            this.dataGridEntradasCompradas.DataSource = this.entradasCompradas;

            this.mostrarMontoTotal();

            List<string> encabezados = new List<string>(new string[] { "TipoId", "Id", "Compra", "UbicacionId" });

            foreach (DataGridViewColumn column in this.dataGridEntradasCompradas.Columns)
            {
                if (encabezados.Contains(column.HeaderText))
                    column.Visible = false;
            }

            this.dataGridEntradasCompradas.AutoSize = false;
            this.dataGridEntradasCompradas.ScrollBars = ScrollBars.Both;
            this.dataGridEntradasCompradas.ClearSelection();
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            if (this.dataGridEntradasCompradas.SelectedRows.Count == 0 || this.dataGridEntradasCompradas.CurrentRow == null)
                MessageBox.Show("Debe seleccionar una ubicación!", "Listado de ubicaciones.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Entrada entrada = (Entrada)this.dataGridEntradasCompradas.CurrentRow.DataBoundItem;
                this.entradasCompradas.Remove(entrada);
                this.load_entradas();
                this.form_ubicacion.regresarEntrada(entrada);
                this.mostrarMontoTotal();
            }
            this.dataGridEntradasCompradas.ClearSelection();
        }

        private void mostrarMontoTotal()
        {
            double precioTotal = 0.0;

            if (dataGridEntradasCompradas.DataSource != null && this.entradasCompradas.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridEntradasCompradas.Rows)
                {
                    Entrada entrada = row.DataBoundItem as Entrada;
                    precioTotal += entrada.Precio;
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
            if(this.entradasCompradas.Count == 0)
                MessageBox.Show("Debes elegir al menos una ubicación!", "Error compra.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (this.cliente.DatosTarjeta == null)
            {
                MessageBox.Show("Debes ingresar una tarjeta!", "Error compra.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Compra_Agregar_Tarjeta tarjeta = new Compra_Agregar_Tarjeta(this, this.cliente);
                tarjeta.ShowDialog();
            }
        }
    }
}
