using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Comisiones_Detalle : Master
    {
        EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
        ComisionesService comisionesService = (ComisionesService)ServiceFactory.GetService("Comisiones");

        public Comisiones_Detalle()
        {
            InitializeComponent();
            try
            {
                this.dataGridViewEmpresas.DataSource = empresaService.getEmpresasComisiones();
            }
            catch(Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Comisiones_Detalle_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }
    }
}
