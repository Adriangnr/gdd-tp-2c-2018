using PalcoNet.Modelo.Entidades;
using PalcoNet.Servicios;
using PalcoNet.Servicios.ServiceFactory;
using PalcoNet.Src.Forms.Layouts;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Rol_Detalle : Master
    {
        private Rol_Listado rol_listado;
        private Rol rol;

        public Rol_Detalle(Rol_Listado rol_listado, Rol rol)
        {
            this.rol = rol;
            this.rol_listado = rol_listado;
            InitializeComponent();
        }

        private void Rol_Detalle_Load(object sender, System.EventArgs e)
        {
            RolService rolService = (RolService)ServiceFactory.GetService("RolService");

            list_funcionalidades.DataSource = rolService.getAllFuncionalidades();
            textBox_nombre.Text = rol.Nombre;

            if(rol.Estado)
                habilitado.CheckState = CheckState.Checked;

            for (int i = 0; i < list_funcionalidades.Items.Count; i++)
            {
                Funcionalidad fun = (Funcionalidad)list_funcionalidades.Items[i];
                foreach (Funcionalidad fun_rol in rol.GetFuncionalidades())
                {
                    if(fun_rol.GetId().Equals(fun.GetId()))
                    {
                        list_funcionalidades.SetItemChecked(i, true);
                        fun_rol.SetEstado(Funcionalidad.EstadoFuncionalidad.SIN_CAMBIOS);
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, System.EventArgs e)
        {
            rol_listado.Show();
            Close();
        }

        private void btn_guardar_Click(object sender, System.EventArgs e)
        {
            RolService rolService = (RolService)ServiceFactory.GetService("RolService");
            if (!habilitado.Checked && rol.Estado)
            {
                rolService.deleteRol(rol.Id);
                rol.Estado = false;
            } 
            else if ( habilitado.Checked && !rol.Estado)
            {
                rolService.habilitarRol(rol.Id);
                rol.Estado = true;
            }
        }
    }
}
