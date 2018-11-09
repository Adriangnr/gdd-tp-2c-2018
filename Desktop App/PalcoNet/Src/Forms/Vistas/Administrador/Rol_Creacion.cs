using PalcoNet.Modelo.Entidades;
using PalcoNet.Servicios;
using PalcoNet.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Rol_Creacion : Layouts.Master
    {
        public Rol_Creacion()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            String nombre_rol = textBox_nombre.Text;
            if (String.IsNullOrWhiteSpace(nombre_rol))

                MessageBox.Show("Debe ingresar el nombre del nuevo rol.");
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
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Rol_Creacion_Load(object sender, EventArgs e)
        {
            RolService rolService = (RolService)ServiceFactory.GetService("RolService");
            list_funcionalidades.DataSource = rolService.getAllFuncionalidades();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
