using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Facturas_Listado : Master
    {
        public PalcoNet.Src.Modelo.Entidades.Empresa empresa { get; set; }

        private FacturaService facturaService = (FacturaService)ServiceFactory.GetService("Factura");

        public Facturas_Listado()
        {
            InitializeComponent();
            this.dataGridViewFacturas.DataSource = this.facturaService.getFacturasByEmpresa(this.empresa.Id);
        }

        private void btn_cancel_Click(object sender, System.EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }
    }
}
