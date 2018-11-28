﻿using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Servicios;
using System;
using System.Windows.Forms;
using PalcoNet.Src.Forms.Vistas.General;

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

        private void loadClientList()
        {
            ClienteService clienteService = (ClienteService)ServiceFactory.GetService("Cliente");
            try
            {
                this.dataGridClientes.DataSource = clienteService.Search(this.groupBox1.Controls);

                if (this.dataGridClientes.Rows.Count == 0)
                    MessageBox.Show("No se encontraron clientes!", "Listado de clientes.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < this.dataGridClientes.Columns.Count; i++)
                    this.dataGridClientes.Columns[i].Visible = false;

                this.dataGridClientes.Columns[0].Visible = true;
                this.dataGridClientes.Columns[1].Visible = true;
                this.dataGridClientes.Columns[2].Visible = true;
                this.dataGridClientes.Columns[8].Visible = true;
                this.dataGridClientes.Columns[9].Visible = true;

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
                    if ((string)this.dataGridClientes.CurrentRow.Cells[9].Value == "Si")
                    {
                        this.dataGridClientes.CurrentRow.Cells[9].Value = "No";
                    }
                    else
                    {
                        this.dataGridClientes.CurrentRow.Cells[9].Value = "Si";
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
                MessageBox.Show("No se seleccionó ningún cliente!", "Cambiar estado del cliente.",
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
                    MessageBox.Show("Error al editar el cliente!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
       
        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((string)this.dataGridClientes.CurrentRow.Cells[9].Value == "Si")
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
    }
}
