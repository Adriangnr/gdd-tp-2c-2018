using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Forms.Layouts;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.General
{
    public partial class Selector_Rol : Master
    {
        Usuario user = null;

        public Selector_Rol(Form previous, Usuario user)
        {
            InitializeComponent();
            this.user = user;
            this.previous = previous;
            this.combo_rol.DataSource = this.user.GetRoles();
            this.ActiveControl = title;
            this.combo_rol.KeyDown += combo_rol_KeyDown;
        }

        void combo_rol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_confirm_Click(sender, new EventArgs());
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

            MenuPrincipal menuPrincipal = new MenuPrincipal(this, this.user);

            this.Hide();
            menuPrincipal.Show();
            //this.previous.Close();
        }

        public void deseleccionarRol()
        {
            this.user.deseleccionarRol();
        }

        private void btn_selctRol_salir_Click(object sender, EventArgs e)
        {
            ((Login)this.previous).clearFields();
            this.previous.Show();
            this.Hide();
        }
    }
}
