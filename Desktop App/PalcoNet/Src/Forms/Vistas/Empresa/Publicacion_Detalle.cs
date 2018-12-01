using PalcoNet.Src.Forms.Layouts;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Publicacion_Detalle : Master
    {
        public Publicacion_Detalle()
        {
            InitializeComponent();
        }

        public Publicacion_Detalle(Form previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void Publicacion_Detalle_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.Utilities.clearForm(this.Controls);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_pub_cargarFechasHoras_Click(object sender, EventArgs e)
        {
            Fecha_Hora fechaHoraForm = new Fecha_Hora();
            fechaHoraForm.Show();
        }
    }
}
