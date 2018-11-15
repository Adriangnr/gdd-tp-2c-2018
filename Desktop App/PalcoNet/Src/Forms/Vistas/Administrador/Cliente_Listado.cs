using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Servicios;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Cliente_Listado : Listado
    {
        public Cliente_Listado()
        {
            InitializeComponent();
        }

        private void Cliente_Listado_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = (ClienteService)ServiceFactory.GetService("Cliente");
            try
            {
                this.dataGridClientes.DataSource = clienteService.Search(this.groupBox1.Controls);

                for (int i = 0; i < this.dataGridClientes.Columns.Count; i++)
                    this.dataGridClientes.Columns[i].Visible = false;

                this.dataGridClientes.Columns[0].Visible = true;
                this.dataGridClientes.Columns[1].Visible = true;
                this.dataGridClientes.Columns[2].Visible = true;
                this.dataGridClientes.Columns[8].Visible = true;
                this.dataGridClientes.Columns[9].Visible = true;

                this.dataGridClientes.AutoGenerateColumns = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar clientes!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
