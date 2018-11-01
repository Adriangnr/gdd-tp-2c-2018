using PalcoNet.Modelo.Entidades;
using System;
using System.Windows.Forms;

namespace PalcoNet.Vistas.General
{
    public partial class Selector_Rol : Layouts.Master
    {
        public Selector_Rol(Form previous, Usuario user)
        {
            InitializeComponent();
            this.combo_rol.DataSource = user.GetRoles();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
