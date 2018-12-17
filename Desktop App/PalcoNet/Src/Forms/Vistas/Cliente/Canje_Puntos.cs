using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Canje_Puntos : Master
    {
        private Src.Modelo.Entidades.Cliente Cliente;

        public Canje_Puntos()
        {
            InitializeComponent();
        }

        private void Canje_Puntos_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteService clienteService = new ClienteService();

                Src.Modelo.Entidades.Cliente cliente = clienteService.GetClienteByUsername(this.usuario.Username);
                this.Cliente = cliente;

                clienteService.getPuntaje(this.Cliente);

                this.points.Text = this.Cliente.Puntos.ToString();

                ProductoService productoService = new ProductoService();

                this.dataGridPremios.DataSource = productoService.getAllProducto();
                List<string> encabezados = new List<string>(new string[] { "Id" });
                foreach (DataGridViewColumn column in this.dataGridPremios.Columns)
                {
                    if (encabezados.Contains(column.HeaderText))
                        column.Visible = false;
                }

                this.dataGridPremios.AutoSize = false;
                this.dataGridPremios.ScrollBars = ScrollBars.Both;
                this.dataGridPremios.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_canjear_Click(object sender, EventArgs e)
        {
            if (dataGridPremios.SelectedRows.Count == 0)
                MessageBox.Show("Debe seleccionar un producto!", "Canje de productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Producto producto = ((Producto)dataGridPremios.CurrentRow.DataBoundItem);

                if (producto.Valor > this.Cliente.Puntos)
                {
                    MessageBox.Show("No tiene puntos suficientes!", "Canje de productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Desea obtener " + producto.ToString()
                , "Canje de productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        ProductoService productoService = new ProductoService();

                        productoService.canjearProducto(this.Cliente.Id, producto.Id, producto.Valor);

                        this.Cliente.Puntos -= producto.Valor;
                        this.points.Text = this.Cliente.Puntos.ToString();
                        MessageBox.Show("Canje exitoso! Recibirá un email con instrucciones para su retiro."
                            , "Canje de productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            Canje_Punto_Historial historial = new Canje_Punto_Historial(this, this.Cliente);

            historial.ShowDialog();
        }
    }
}
