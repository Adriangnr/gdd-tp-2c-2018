using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Selector_Comisiones : Master
    {
        ComisionesService comisionesService = (ComisionesService)ServiceFactory.GetService("Comisiones");
        EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
        CompraService compraService = (CompraService)ServiceFactory.GetService("Compra");
        int empresaId;

        public Selector_Comisiones()
        {
            InitializeComponent();
            Modelo.Entidades.Empresa empresa = empresaService.GetEmpresa(empresaId);
            this.labelNombreEmpresa.Text = empresa.RazonSocial;
            this.labelCanCompras.Text = compraService.getComprasOfEmpresa(empresaId).ToString();
        }

        public void setEmpresa(int id)
        {
            this.empresaId = id;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }
    }
}
