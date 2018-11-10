using PalcoNet.Modelo.Entidades;
using PalcoNet.Servicios;
using PalcoNet.Servicios.ServiceFactory;
using PalcoNet.Src.Forms.Layouts;

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
            list_funcionalidades.DataSource = rol.GetFuncionalidades();
            textBox_nombre.Text = rol.Nombre;
        }

        private void btn_cancel_Click(object sender, System.EventArgs e)
        {
            rol_listado.Show();
            Close();
        }
    }
}
