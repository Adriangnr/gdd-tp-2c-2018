using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Selector_Comisiones : Master
    {
        ComisionesService comisionesService = (ComisionesService)ServiceFactory.GetService("Comisiones");

        public Selector_Comisiones()
        {
            InitializeComponent();

        }
    }
}
