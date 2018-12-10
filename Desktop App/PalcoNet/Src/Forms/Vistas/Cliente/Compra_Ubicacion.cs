﻿using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra_Ubicacion : Master
    {
        private int publicacion;
        private List<Entrada> entradasCompradas;

        public Compra_Ubicacion(Form previous, int publicacion, List<Entrada> entradasCompradas)
        {
            InitializeComponent();
            this.previous = previous;
            this.publicacion = publicacion;
            this.entradasCompradas = entradasCompradas;
            loadEntradas(publicacion);
        }

        private void loadEntradas(int publicacion)
        {
            EntradaService entradaService = new EntradaService();
            try
            {
                Console.WriteLine(publicacion);

                this.dataGridEntradas.DataSource = entradaService.GetAllEntradasDisponibles(this.publicacion);

                List<string> encabezados = new List<string>(new string[] {"TipoId","Id", "Compra", "UbicacionId"});

                foreach (DataGridViewColumn column in this.dataGridEntradas.Columns)
                {
                    if ( encabezados.Contains(column.HeaderText))
                        column.Visible = false;
                }

                this.dataGridEntradas.AutoSize = false;
                this.dataGridEntradas.ScrollBars = ScrollBars.Both;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al buscar ubicaciones!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            entradasCompradas.Add((Entrada)this.dataGridEntradas.CurrentRow.DataBoundItem);
            dataGridEntradas.Rows.Remove(dataGridEntradas.CurrentRow);
            ((Compra_Detalle)this.previous).load_entradas();
            ((Compra_Detalle)this.previous).dataGridEntradasCompradas.Refresh();
            this.Hide();
        }
    }
}