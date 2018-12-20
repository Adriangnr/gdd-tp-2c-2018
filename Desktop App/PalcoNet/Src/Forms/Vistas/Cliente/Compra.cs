using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Forms.Vistas.Paginador;
using PalcoNet.Src.Utils;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra : Listado, Pageable
    {
        private List<Rubro> categoriasElegidas = new List<Rubro>();
        private Paginator paginator;
        public Dictionary<string, string> filtros { get; set; }

        public Compra()
        {
            InitializeComponent();
            agregarCategoria.BackgroundImage = Properties.Resources.plus_icon;
            quitarCategoria.BackgroundImage = Properties.Resources.minus_icon;
            fechaInicioVista.Value = Utils.Utilities.getCurrentDate();
            fechaFinVista.Value = Utils.Utilities.getCurrentDate();
            RubroService rubroService = new RubroService();
            categoriasComboBox.DataSource = rubroService.getAllRubros();
            categoriasVista.Text = "";
            System.Drawing.Size size = new System.Drawing.Size(1100, 500);
            this.Size = size;
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            this.cargarListaCompras();
        }

        public void cargarListaCompras()
        {
            CompraService compraService = (CompraService)ServiceFactory.GetService("Compra");
            try
            {
                this.filtros = null;
                this.filtros = new Dictionary<string, string>();
               
                filtros.Add("fechaActual", Utils.Utilities.getCurrentDate().ToString());

                if (fechaInicioCheckBox.Checked)
                {
                    filtros.Add("fechaInicio", fechaInicioVista.Value.ToString());
                }

                if (fechaInicioCheckBox.Checked)
                {
                    filtros.Add("fechaFin", fechaFinVista.Value.ToString());
                }

                if( categoriasVista.Text != "" )
                {
                    TextBox categorias = new TextBox();
                    categorias.Visible = false;

                    string str = "";

                    foreach (Rubro rubro in categoriasElegidas)
                    {
                        if (str == "")
                            str = str + rubro.codigo;
                        else
                            str = str + ", " + rubro.codigo;
                    }

                    categorias.Text = "("+str+")";
                    filtros.Add("categorias", categorias.Text);
                }

                if(this.descripcion.Text != "") filtros.Add("descripcion", this.descripcion.Text);

                /*------------ Paginador ---------------*/
                this.paginator = new CompraPublicacionPaginator(this);
                this.paginator.ItemsPerPage = Utils.Utilities.getTamPagina();
                this.panelPaginatorControls.Controls.Clear();
                this.panelPaginatorControls.Controls.Add(this.paginator.controls);
                Page currentPage = this.paginator.NextPage();
                List<object> objects = currentPage.GetItems();
                List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();
                SortableBindingList<Publicacion> sorteablePublicaciones = new SortableBindingList<Publicacion>(publicaciones);
                /*------------- Fin Paginador ----------*/

                this.dataGridPublicaciones.DataSource = null;
                this.dataGridPublicaciones.DataSource = publicaciones;

                /*if (this.dataGridPublicaciones.Rows.Count == 0)
                    MessageBox.Show("No se encontraron publicaciones!", "Listado de publicaciones activas.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                List<string> encabezados = new List<string>(new string[] { "Codigo", "Fecha de Publicación", "Grado", "Estado", "FechaEventoId" });
                List<string> autoSizeCells = new List<string>(new string[] { "Rubro", "Fecha Evento" });
                foreach (DataGridViewColumn column in this.dataGridPublicaciones.Columns)
                {
                    if (encabezados.Contains(column.HeaderText))
                        column.Visible = false;

                    if (autoSizeCells.Contains(column.HeaderText))
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }


                this.dataGridPublicaciones.AutoGenerateColumns = false;
                this.dataGridPublicaciones.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error al buscar Publicaciones!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void agregarCategoria_Click(object sender, EventArgs e)
        {
            Rubro rubro = (Rubro)categoriasComboBox.SelectedItem;

            if (!categoriasElegidas.Contains(rubro))
            {
                categoriasElegidas.Add(rubro);
                mostrarCategorias();
            }
        }

        private void mostrarCategorias()
        {
            string str = "";

            foreach (Rubro rubro in categoriasElegidas)
            {
                if (str == "")
                    str = rubro.ToString();
                else
                    str = str + ", " + rubro.ToString();
            }

            categoriasVista.Text = str;
        }

        private void quitarCategoria_Click(object sender, EventArgs e)
        {
            Rubro rubro = (Rubro)categoriasComboBox.SelectedItem;

            if (categoriasElegidas.Contains(rubro))
            {
                categoriasElegidas.Remove(rubro);
                mostrarCategorias();
            }
        }

        private new void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            base.linkLabel1_LinkClicked(sender, e);
            categoriasElegidas.Clear();
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
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.Refresh();
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.dataGridPublicaciones.ClearSelection();
            this.dataGridPublicaciones.Refresh();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {

            if (dataGridPublicaciones.SelectedRows.Count == 0)
                MessageBox.Show("Debe seleccionar una publicacion!", "Listado de entradas.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    Compra_Detalle compra_detalle = new Compra_Detalle(this, this.usuario, (Publicacion)this.dataGridPublicaciones.CurrentRow.DataBoundItem);

                    compra_detalle.ShowDialog();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.paginator = null;
            this.cargarListaCompras();
        }
    }
}
