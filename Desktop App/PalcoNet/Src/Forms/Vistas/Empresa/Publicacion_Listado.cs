using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Publicacion_Listado : Master
    {
        public Publicacion_Listado()
        {
            InitializeComponent();
        }

        private void Pulicacion_Listado_Load(object sender, EventArgs e)
        {
           Console.WriteLine("Buscando Publicaciones del usuario " + this.usuario);
           EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
           
           this.dataGridPublicaciones.DataSource = empresaService.GetPublicaciones(this.usuario.Username);
        }

        private void Entidad_Click(object sender, EventArgs e)
        {

        }
    }
}
