using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Servicios;
using System;
using System.Windows.Forms;
using PalcoNet.Src.Forms.Vistas.General;
using System.ComponentModel;

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
           this.loadClientList();
        }

        public void loadClientList()
        {
            ClienteService clienteService = (ClienteService)ServiceFactory.GetService("Cliente");
            try
            {
                this.dataGridClientes.DataSource = clienteService.Search(this.groupBox1.Controls);

                this.dataGridClientes.AutoSize = false;
                this.dataGridClientes.ScrollBars = ScrollBars.Both;

                /*if (this.dataGridClientes.Rows.Count == 0)
                    MessageBox.Show("No se encontraron clientes!", "Listado de clientes.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);*/

               foreach (DataGridViewColumn column in this.dataGridClientes.Columns)
               {
                   // La columna 0 es el id del cliente
                   if (column.Index == 0 || column.Index > 6)
                       column.Visible = false;
                   if (column.HeaderText == "Habilitado")
                       column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                   // Para que empiece ordenado de menor a mayor: nro de documento
                   if (column.Index == 3)
                   {
                       this.dataGridClientes.Sort(column, ListSortDirection.Ascending);
                       column.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
                   }
                   column.SortMode = DataGridViewColumnSortMode.Automatic;
               }

                this.dataGridClientes.AutoGenerateColumns = false;
                this.dataGridClientes.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al buscar clientes!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.loadClientList();
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            if (this.dataGridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionó ningún cliente!", "Cambiar estado del cliente.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    ClienteService clienteService = (ClienteService)ServiceFactory.GetService("Cliente");
                    clienteService.modifyStatus((int)this.dataGridClientes.CurrentRow.Cells[0].Value);

                    this.dataGridClientes.ReadOnly = false;
                    if ((string)this.dataGridClientes.CurrentRow.Cells[6].Value == "Si")
                    {
                        this.dataGridClientes.CurrentRow.Cells[6].Value = "No";
                    }
                    else
                    {
                        this.dataGridClientes.CurrentRow.Cells[6].Value = "Si";
                    }

                    this.dataGridClientes.ClearSelection();
                    this.dataGridClientes.Refresh();
                    this.dataGridClientes.ReadOnly = true;

                    MessageBox.Show("Se cambio el estado del cliente con exito!", "Cambiar estado del cliente.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error al deshabilitar el cliente!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.dataGridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionó ningún cliente!", "Editar cliente.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    ClienteService clienteService = (ClienteService)ServiceFactory.GetService("Cliente");
                    PalcoNet.Src.Modelo.Entidades.Cliente client = clienteService.GetCliente((int)this.dataGridClientes.CurrentRow.Cells[0].Value);
                    Cliente_Edicion editForm = new Cliente_Edicion();
                    editForm.setPrevious(this);
                    editForm.loadData(client);
                    editForm.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("Error al editar el cliente!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
       
        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((string)this.dataGridClientes.CurrentRow.Cells[6].Value == "Si")
            {
                this.btn_habilitar.Text = "Deshabilitar";
            }
            else
            {
                this.btn_habilitar.Text = "Habilitar";
            }
            this.btn_habilitar.Refresh();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Registro formRegistro = new Registro(this);
            formRegistro.setearTipoUsuario("Cliente");
            formRegistro.Show();
            this.Hide();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
        }
    }
}
