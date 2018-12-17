using PalcoNet.Src.Forms.Layouts;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Facturas_Listado : Master
    {
        public PalcoNet.Src.Modelo.Entidades.Empresa empresa { get; set; }

        public Facturas_Listado()
        {
            InitializeComponent();
        }
    }
}
