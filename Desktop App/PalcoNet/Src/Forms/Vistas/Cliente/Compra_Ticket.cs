using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra_Ticket : Master
    {
        private Src.Modelo.Entidades.Compra_Ticket Compra;
        private Src.Modelo.Entidades.Cliente Cliente;

        public Compra_Ticket(Form historial, Src.Modelo.Entidades.Cliente cliente, Src.Modelo.Entidades.Compra_Ticket compra)
        {
            this.previous = historial;
            this.Compra = compra;
            this.Cliente = cliente;
            InitializeComponent();
        }

        private void Compra_Ticket_Load(object sender, EventArgs e)
        {
            try
            {
                CompraService compraService = new CompraService();
                compraService.getDetallesCompra(this.Compra);

                label_nombre.Text = Cliente.Nombre;
                label_apellido.Text = Cliente.Apellido;
                label_mail.Text = Cliente.Email;
                label_tarjeta.Text = Cliente.DatosTarjeta;
                label_total.Text = Compra.MontoTotal.ToString();
                label_espectaculo.Text = Compra.Publicacion;
                label_fecha.Text = Compra.Entradas[0].FechaEvento.ToString();

                SortableBindingList<Entrada_Ticket> entradas = new SortableBindingList<Entrada_Ticket>(this.Compra.Entradas);

                this.dataGridHistorialEntradas.DataSource = entradas;

                List<string> encabezados = new List<string>(new string[] { "FechaEvento" });

                foreach (DataGridViewColumn column in this.dataGridHistorialEntradas.Columns)
                {
                    if (encabezados.Contains(column.HeaderText))
                        column.Visible = false;

                  /*  if (column.HeaderText == "Publicacion" || column.HeaderText == "Direccion")
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
                }

                this.dataGridHistorialEntradas.AutoSize = false;
                this.dataGridHistorialEntradas.ScrollBars = ScrollBars.Both;
                this.dataGridHistorialEntradas.ClearSelection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Compra.Entradas.Clear(); ;
            this.Close();
        }
    }
}
