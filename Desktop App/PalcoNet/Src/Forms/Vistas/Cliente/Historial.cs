using PalcoNet.Src.Forms.Layouts;
using System;

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
            this.Hide();
        }
    }
}
