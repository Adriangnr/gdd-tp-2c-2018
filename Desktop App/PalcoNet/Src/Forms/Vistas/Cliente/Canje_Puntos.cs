using PalcoNet.Src.Forms.Layouts;
using System;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Canje_Puntos : Master
    {
        public Canje_Puntos()
        {
            InitializeComponent();
        }

        private void Canje_Puntos_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }
    }
}
