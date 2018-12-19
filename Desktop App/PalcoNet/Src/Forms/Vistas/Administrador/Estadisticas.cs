using PalcoNet.Src.Forms.Layouts;
using System;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Estadisticas : Master
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
