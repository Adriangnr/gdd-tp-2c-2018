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
    public partial class Canje_Punto_Historial : Master
    {
        private Src.Modelo.Entidades.Cliente Cliente;

        public Canje_Punto_Historial(Form previous, Src.Modelo.Entidades.Cliente cliente)
        {
            this.Cliente = cliente;
            this.previous = previous;
            InitializeComponent();
        }

        private void Canje_Punto_Historial_Load(object sender, EventArgs e)
        {
            try
            {

                ProductoService productoService = new ProductoService();

                this.dataGridPremiosHistorial.DataSource = productoService.getHistorialCanje(this.Cliente);

                List<string> encabezados = new List<string>(new string[] { "Id" });

                foreach (DataGridViewColumn column in this.dataGridPremiosHistorial.Columns)
                {
                    if (encabezados.Contains(column.HeaderText))
                        column.Visible = false;
                }

                this.dataGridPremiosHistorial.AutoSize = false;
                this.dataGridPremiosHistorial.ScrollBars = ScrollBars.Both;
                this.dataGridPremiosHistorial.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
