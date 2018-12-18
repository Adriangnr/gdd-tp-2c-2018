using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Factura_Detalle : Master
    {
        public Factura factura {get; set;}
        public FacturaService facturaService =  (FacturaService)ServiceFactory.GetService("Factura");

        public Factura_Detalle(Factura factura)
        {
            this.factura = factura;
            InitializeComponent();
            this.loadFields();
        }

        private void loadFields()
        {
            this.codigo.Text = this.factura.id.ToString();
            this.fecha.Text = this.factura.fecha.ToString();
            this.formaPago.Text = "Efectivo";
            this.totalComision.Text = this.factura.totalComision.ToString();
            this.total.Text = this.factura.total.ToString();
            
            this.dataGridViewItems.DataSource = this.facturaService.getItems(this.factura.id);
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }
    }
}
