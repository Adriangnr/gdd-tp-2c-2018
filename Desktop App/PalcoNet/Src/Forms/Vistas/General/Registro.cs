using PalcoNet.Src.Forms.Layouts;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class Registro : Master
    {
        public Registro(Form previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }

        private void register_btn_registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear la entidad Usuario. Crear la entidad tipo de usuario y metarla dentro de " +
                "Usuario. Guardar usuario. Redireccionar a Login.");
            this.Hide();
            this.previous.Show();
        }
    }
}
