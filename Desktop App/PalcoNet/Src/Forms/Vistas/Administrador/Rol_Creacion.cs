using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Rol_Creacion : Layouts.Master
    {
        private Rol_Listado form_rol_listado;

        public Rol_Creacion(Rol_Listado _form_anterior)
        {
            this.form_rol_listado = _form_anterior;
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            String nombre_rol = textBox_nombre.Text;

            if (String.IsNullOrWhiteSpace(nombre_rol))

                MessageBox.Show("Debe ingresar el nombre del nuevo rol.", Titulo.ERROR);

            else if (list_funcionalidades.CheckedItems.Count < 1)
            {
                MessageBox.Show("Un rol debe tener al menos una funcionalidad.", Titulo.ERROR);

            }
            else
            {
                List<Funcionalidad> funcionalidades_nuevas = list_funcionalidades.CheckedItems.OfType<Funcionalidad>().ToList();

                RolService rolService = (RolService)ServiceFactory.GetService("RolService");

                Rol rol_nuevo = new Rol();
                rol_nuevo.Nombre = nombre_rol;
                funcionalidades_nuevas.ForEach(func => rol_nuevo.AgregarFuncionalidad(func));
                try
                {
                    rolService.saveRol(rol_nuevo);
                    MessageBox.Show(String.Format("El rol '{0}' fue creado con exito.", nombre_rol), Titulo.EXITO);
                    form_rol_listado.actualizarListadoRoles();
                    form_rol_listado.Show();
                    Close();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, Titulo.ERROR);
                    this.ActiveControl = textBox_nombre;
                }
            }
        }

        private void Rol_Creacion_Load(object sender, EventArgs e)
        {
            RolService rolService = (RolService)ServiceFactory.GetService("RolService");
            list_funcionalidades.DataSource = rolService.getAllFuncionalidades();
            this.ActiveControl = textBox_nombre;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form_rol_listado.Show();
            Close();
        }

        private void label_limpiar_seleccion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < list_funcionalidades.Items.Count; i++)
            {
                list_funcionalidades.SetItemChecked(i, false);
            }
        }
    }
}
