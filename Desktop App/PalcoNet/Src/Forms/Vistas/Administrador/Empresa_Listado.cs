﻿using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Empresa_Listado : Listado
    {
        public Empresa_Listado()
        {
            InitializeComponent();
        }

        private void Empresa_Listado_Load(object sender, EventArgs e)
        {
            this.cargarListadoEmpresas();
        }

        private void cargarListadoEmpresas()
        {
            EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
            try
            {
                this.dataGridEmpresas.DataSource = empresaService.Search(this.groupBox1.Controls);

                if (this.dataGridEmpresas.Rows.Count == 0)
                    MessageBox.Show("No se encontraron empresas!", "Listado de empresas.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.dataGridEmpresas.Columns[2].Visible = false;
                this.dataGridEmpresas.Columns[6].Visible = false;

                this.dataGridEmpresas.AutoGenerateColumns = false;
                this.dataGridEmpresas.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al buscar empresas!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.cargarListadoEmpresas();
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            if (this.dataGridEmpresas.CurrentRow == null)
            {
                MessageBox.Show("No se seleccionó ningún cliente!", "Cambiar estado del cliente.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
                    empresaService.modifyStatus((int)this.dataGridEmpresas.CurrentRow.Cells[0].Value);

                    this.dataGridEmpresas.ReadOnly = false;
                    if ((string)this.dataGridEmpresas.CurrentRow.Cells[4].Value == "Si")
                    {
                        this.dataGridEmpresas.CurrentRow.Cells[4].Value = "No";
                    }
                    else
                    {
                        this.dataGridEmpresas.CurrentRow.Cells[4].Value = "Si";
                    }
                    this.dataGridEmpresas.ClearSelection();
                    this.dataGridEmpresas.Refresh();
                    this.dataGridEmpresas.ReadOnly = true;

                    MessageBox.Show("Se cambio el estado de la empresa con exito!", "Cambiar estado de empresa.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((string)this.dataGridEmpresas.CurrentRow.Cells[4].Value == "Si")
            {
                this.btn_habilitar.Text = "Deshabilitar";
            }
            else
            {
                this.btn_habilitar.Text = "Habilitar";
            }
            this.btn_habilitar.Refresh();
        }
    }
}
