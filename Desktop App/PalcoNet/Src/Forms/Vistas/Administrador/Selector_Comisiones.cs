using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Selector_Comisiones : Master
    {
        ComisionesService comisionesService = (ComisionesService)ServiceFactory.GetService("Comisiones");
        CompraService compraService = (CompraService)ServiceFactory.GetService("Compra");
        Modelo.Entidades.Empresa empresa { get; set; }

        public Selector_Comisiones(Modelo.Entidades.Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            this.labelNombreEmpresa.Text = empresa.RazonSocial;
            this.labelCanCompras.Text = compraService.getCountComprasOfEmpresa(empresa.Id).ToString();
        }
        
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }

        private void btnComisiones_Click(object sender, System.EventArgs e)
        {
            try
            {
                comisionesService.comisionar(Convert.ToInt16(this.txtCantComisiones.Text), this.empresa.Id);
                MessageBox.Show("Comisiones rendidas con exito!", "Rendición de comisiones!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((Comisiones_Detalle)this.previous).reload();
                this.previous.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error al rendir comisiones!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
