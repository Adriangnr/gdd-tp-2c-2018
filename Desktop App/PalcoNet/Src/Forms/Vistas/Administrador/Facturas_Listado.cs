using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Facturas_Listado : Master
    {
        public PalcoNet.Src.Modelo.Entidades.Empresa empresa { get; set; }

        private FacturaService facturaService = (FacturaService)ServiceFactory.GetService("Factura");

        public Facturas_Listado(PalcoNet.Src.Modelo.Entidades.Empresa empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
            this.dataGridViewFacturas.DataSource = this.facturaService.getFacturasByEmpresa(this.empresa.Id);
        }

        private void btn_cancel_Click(object sender, System.EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }

        private void btnVerDetalle_Click(object sender, System.EventArgs e)
        {
            if (this.dataGridViewFacturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionó ninguna factura!", "Ver factura.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Factura factura = (Factura)this.dataGridViewFacturas.CurrentRow.DataBoundItem;
                this.dataGridViewFacturas.Columns[2].Visible = false;
                this.dataGridViewFacturas.Columns[3].Visible = false;

                Factura_Detalle facturaDetalle = new Factura_Detalle(factura);
                facturaDetalle.previous = this;
                facturaDetalle.Show();
                this.Hide();
            }
        }
    }
}
