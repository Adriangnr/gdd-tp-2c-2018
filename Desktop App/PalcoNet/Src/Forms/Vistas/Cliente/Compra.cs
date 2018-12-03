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

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra : Listado, Pageable
    {
        private List<Rubro> categoriasElegidas = new List<Rubro>();
        private Paginator paginator;

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
                System.Windows.Forms.Control.ControlCollection filtros = groupBox1.Controls;

                DateTimePicker fechaActivaFilter = new DateTimePicker();
                fechaActivaFilter.Visible = false;
                fechaActivaFilter.Name = "fechaActual";
                fechaActivaFilter.Value = Utils.Utilities.getCurrentDate();
                filtros.Add(fechaActivaFilter);

                if (fechaInicioCheckBox.Checked)
                {
                    DateTimePicker fechaInicio = new DateTimePicker();
                    fechaInicio.Visible = false;
                    fechaInicio.Name = "fechaInicio";
                    fechaInicio.Value = fechaInicioVista.Value;
                    filtros.Add(fechaInicio);
                }

                if (fechaInicioCheckBox.Checked)
                {
                    DateTimePicker fechaFin = new DateTimePicker();
                    fechaFin.Visible = false;
                    fechaFin.Name = "fechaFin";
                    fechaFin.Value = fechaFinVista.Value;
                    filtros.Add(fechaFin);
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

                    categorias.Text = str;
                    filtros.Add(categorias);
                }

                /*------------ Paginador ---------------*/
                this.paginator = new CompraPublicacionPaginator(this);
                this.paginator.ItemsPerPage = 10;
                this.panelPaginatorControls.Controls.Add(this.paginator.controls);
                Page currentPage = this.paginator.NextPage();
                List<object> objects = currentPage.GetItems();
                List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();
                /*------------- Fin Paginador ----------*/

                this.dataGridPublicaciones.DataSource = compraService.getAllPublicacionesParaCompra(filtros);

                if (this.dataGridPublicaciones.Rows.Count == 0)
                    MessageBox.Show("No se encontraron publicaciones!", "Listado de publicaciones activas.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                foreach (DataGridViewColumn column in this.dataGridPublicaciones.Columns)
                {
                    // La columna 0 es el id de la empresa
                    //if (column.Index == 0 || column.Index > 5)
                      //  column.Visible = false;
                    //if (column.HeaderText == "Habilitado")
                      //  column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    // Para que empiece ordenado de menor a mayor: razon social
                    if (column.Index == 1)
                    {
                        this.dataGridPublicaciones.Sort(column, ListSortDirection.Ascending);
                        column.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
                    }
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }

                this.dataGridPublicaciones.AutoGenerateColumns = false;
                this.dataGridPublicaciones.ClearSelection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            throw new NotImplementedException();
        }

        public void btn_firstPage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void btn_previousPage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void btn_lastPage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
