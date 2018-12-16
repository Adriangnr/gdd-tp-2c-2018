using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Historial : Master
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();

            Src.Modelo.Entidades.Cliente cliente = clienteService.GetClienteByUsername(this.usuario.Username);

            CompraService compraService = new CompraService();
            try
            {
                this.dataGridHistorial.DataSource = compraService.getAllCompras(cliente);

                List<string> encabezados = new List<string>(new string[] {"ClienteNombre", "ClienteApellido"});

                foreach (DataGridViewColumn column in this.dataGridHistorial.Columns)
                {
                    if (encabezados.Contains(column.HeaderText))
                        column.Visible = false;

                    if (column.HeaderText == "Publicacion" || column.HeaderText == "Direccion")
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                this.dataGridHistorial.AutoSize = false;
                this.dataGridHistorial.ScrollBars = ScrollBars.Both;
                this.dataGridHistorial.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            if (this.dataGridHistorial.SelectedRows.Count == 0 )
                MessageBox.Show("Debe seleccionar una compra!", "Historial",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Compra_Ticket compra_ticket = new Compra_Ticket(this, (Src.Modelo.Entidades.Compra)this.dataGridHistorial.CurrentRow.DataBoundItem);
                compra_ticket.ShowDialog();

            }
            this.dataGridHistorial.ClearSelection();
        }
    }
}
