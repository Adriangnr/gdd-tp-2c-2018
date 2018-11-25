using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Rol_Detalle : Master
    {
        private Rol_Listado rol_listado;
        private Rol rol;

        public Rol_Detalle() { }

        public Rol_Detalle(Rol_Listado rol_listado, Rol rol)
        {
            this.rol = rol;
            this.rol_listado = rol_listado;
            rol.CargarFuncionalidades();
            InitializeComponent();
        }

        private void Rol_Detalle_Load(object sender, System.EventArgs e)
        {
            RolService rolService = (RolService)ServiceFactory.GetService("Rol");

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
                        fun.SetEstado(Funcionalidad.EstadoFuncionalidad.SIN_CAMBIOS);
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
            RolService rolService = (RolService)ServiceFactory.GetService("Rol");

            List<Funcionalidad> funcionalidades_cambiadas = new List<Funcionalidad>();

            bool huboCambios = false;

            if (!habilitado.Checked && rol.Estado)
            {
                rolService.deleteRol(rol.Id);
                rol.Estado = false;
                huboCambios = true;
            } 
            else if ( habilitado.Checked && !rol.Estado)
            {
                rolService.habilitarRol(rol.Id);
                rol.Estado = true;
                huboCambios = true;
            }

            foreach (object item in list_funcionalidades.Items)
            {

                Funcionalidad fun = (Funcionalidad)item;

                if (list_funcionalidades.CheckedItems.Contains(item))
                {
                    if (fun.GetEstado().Equals(Funcionalidad.EstadoFuncionalidad.SIN_ESTADO))
                    {
                        fun.SetEstado(Funcionalidad.EstadoFuncionalidad.NUEVO);
                        funcionalidades_cambiadas.Add(fun);
                    }

                }
                else
                {
                    if (fun.GetEstado().Equals(Funcionalidad.EstadoFuncionalidad.SIN_CAMBIOS))
                    {
                        fun.SetEstado(Funcionalidad.EstadoFuncionalidad.BORRADO);
                        funcionalidades_cambiadas.Add(fun);
                    }
                }
            }

            if (funcionalidades_cambiadas.Count != 0)
            {
                rolService.administrarCambiosFuncionalidades(rol.Id, funcionalidades_cambiadas);
                huboCambios = true;
            }

            if (huboCambios) MessageBox.Show("Modificación del rol correcta");

        }
    }
}
