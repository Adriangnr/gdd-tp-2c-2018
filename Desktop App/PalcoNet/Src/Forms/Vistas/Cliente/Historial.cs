using PalcoNet.Src.Forms.Layouts;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Historial : Master
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {

        }
    }
}
