using PalcoNet.Modelo.Entidades;
using PalcoNet.Src.Forms.Vistas.General;
using System;
using System.Windows.Forms;

namespace PalcoNet.Vistas.General
{
    public partial class Selector_Rol : Layouts.Master
    {
        Usuario user = null;

        public Selector_Rol(Form previous, Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.combo_rol.DataSource = this.user.GetRoles();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.user.seleccionarRol(((Rol)this.combo_rol.SelectedItem).Id);

            MenuPrincipal loginMenu = new MenuPrincipal(this, this.user);

            this.Hide();
            loginMenu.Show();
        }
    }
}
