using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Forms.Vistas.Paginador;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Historial : Master, Pageable
    {
        private Src.Modelo.Entidades.Cliente Cliente;
        private ClienteHistorialPaginator paginator;

        public Historial()
        {
            InitializeComponent();
            System.Drawing.Size size = new System.Drawing.Size(1000, 500);
            this.Size = size;
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();

            Src.Modelo.Entidades.Cliente cliente = clienteService.GetClienteByUsername(this.usuario.Username);
            this.Cliente = cliente;

            CompraService compraService = new CompraService();
            try
            {
                /*------------ Paginador ---------------*/
                this.paginator = new ClienteHistorialPaginator(this);
                this.paginator.Entity = this.Cliente;
                this.paginator.ItemsPerPage = Utils.Utilities.getTamPagina();
                this.panelPaginatorControls.Controls.Clear();
                this.panelPaginatorControls.Controls.Add(this.paginator.controls);
                Page currentPage = this.paginator.NextPage();
                List<object> objects = currentPage.GetItems();
                List<PalcoNet.Src.Modelo.Entidades.Compra_Ticket> compras = objects.Cast<PalcoNet.Src.Modelo.Entidades.Compra_Ticket>().ToList();
                this.dataGridHistorial.DataSource = compras;
                this.dataGridHistorial.Columns[6].Visible = false;
                /*------------- Fin Paginador ----------*/

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
                Compra_Ticket compra_ticket = new Compra_Ticket(this, this.Cliente,(Src.Modelo.Entidades.Compra_Ticket)this.dataGridHistorial.CurrentRow.DataBoundItem);
                compra_ticket.ShowDialog();

            }
            this.dataGridHistorial.ClearSelection();
        }

        public void btn_nextPage_Click(object sender, EventArgs e)
        {
            this.changePage(this.paginator.NextPage());
        }

        public void btn_firstPage_Click(object sender, EventArgs e)
        {
            this.changePage(this.paginator.FirstPage());
        }

        public void btn_previousPage_Click(object sender, EventArgs e)
        {
            this.changePage(this.paginator.PreviousPage());
        }

        public void btn_lastPage_Click(object sender, EventArgs e)
        {
            this.changePage(this.paginator.LastPage());   
        }

        private void changePage(Page currentPage)
        {
            List<object> objects = currentPage.GetItems();
            List<PalcoNet.Src.Modelo.Entidades.Compra_Ticket> publicaciones = objects.Cast<PalcoNet.Src.Modelo.Entidades.Compra_Ticket>().ToList();

            this.dataGridHistorial.DataSource = null;
            this.dataGridHistorial.Refresh();
            this.dataGridHistorial.DataSource = publicaciones;
            this.dataGridHistorial.Refresh();
            this.dataGridHistorial.ClearSelection();
        }
    }
}
