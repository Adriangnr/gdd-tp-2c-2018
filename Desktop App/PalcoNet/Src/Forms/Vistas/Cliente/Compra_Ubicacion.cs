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
    public partial class Compra_Ubicacion : Master
    {
        private int publicacion;
        public Compra_Ubicacion(Form previous, int publicacion)
        {
            InitializeComponent();
            this.previous = previous;
            this.publicacion = publicacion;
            loadEntradas(publicacion);
        }

        private void loadEntradas(int publicacion)
        {
            EntradaService entradaService = new EntradaService();
            try
            {
                Console.WriteLine(publicacion);

                this.dataGridEntradas.DataSource = entradaService.GetAllEntradasDisponibles(this.publicacion);

                this.dataGridEntradas.AutoSize = false;
                this.dataGridEntradas.ScrollBars = ScrollBars.Both;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al buscar ubicaciones!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
