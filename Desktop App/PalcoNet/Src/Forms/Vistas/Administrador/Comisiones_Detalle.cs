using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Comisiones_Detalle : Master
    {
        EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
        ComisionesService comisionesService = (ComisionesService)ServiceFactory.GetService("Comisiones");

        public Comisiones_Detalle()
        {
            InitializeComponent();
        }

        public void reload()
        {
            this.Comisiones_Detalle_Load(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Comisiones_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewEmpresas.DataSource = empresaService.getEmpresasComisiones();
                this.dataGridViewEmpresas.Columns[3].Visible = false;
                this.dataGridViewEmpresas.Columns[5].Visible = false;
                this.dataGridViewEmpresas.Columns[6].Visible = false;
                this.dataGridViewEmpresas.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error al cargar empresa!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }

        private void btn_comisionar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewEmpresas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionó ninguna empresa!", "Comisionar ventas.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    PalcoNet.Src.Modelo.Entidades.Empresa empresa = 
                        (PalcoNet.Src.Modelo.Entidades.Empresa) this.dataGridViewEmpresas.CurrentRow.DataBoundItem;
                    Selector_Comisiones selectorComisiones = new Selector_Comisiones(empresa);
                    selectorComisiones.previous = this;
                    selectorComisiones.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error al deshabilitar la empresa!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
