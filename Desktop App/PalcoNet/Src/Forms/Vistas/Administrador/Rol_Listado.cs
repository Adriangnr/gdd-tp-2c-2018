using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Rol_Listado : Master
    {
        public Rol_Listado()
        {
            InitializeComponent();
        }

        private void Rol_Listado_Load(object sender, EventArgs e)
        {
            actualizarListadoRoles();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            new Rol_Creacion(this).Show();
            Hide();
        }

        public void actualizarListadoRoles()
        {
            RolService rolService = (RolService)ServiceFactory.GetService("RolService");
            list_Roles.DataSource = rolService.getAllRoles();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            new Rol_Detalle(this, (Rol) list_Roles.SelectedItem).Show();
            Hide();
        }

    }
}
