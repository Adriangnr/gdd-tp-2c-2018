using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
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
        private Src.Modelo.Entidades.Compra Compra;

        public Compra_Ticket(Form historial, Src.Modelo.Entidades.Compra compra)
        {
            this.previous = historial;
            this.Compra = compra;
            InitializeComponent();
        }

        private void Compra_Ticket_Load(object sender, EventArgs e)
        {
            try
            {
                CompraService compraService = new CompraService();
                compraService.getDetallesCompra(this.Compra);

                this.dataGridHistorialEntradas.DataSource = this.Compra.Entradas;
                label_nombre.Text = Compra.ClienteNombre;
                label_apellido.Text = Compra.ClienteApellido;
                label_espectaculo.Text = Compra.Publicacion;
                label_fecha.Text = Compra.Fecha.ToString();
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
