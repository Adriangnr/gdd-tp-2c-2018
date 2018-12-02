using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra : Listado
    {
        public Compra()
        {
            InitializeComponent();
            agregarCategoria.BackgroundImage = Properties.Resources.plus_icon;
            quitarCategoria.BackgroundImage = Properties.Resources.minus_icon;
            fechaInicioVista.Value = Utils.Utilities.getCurrentDate();
            fechaFinVista.Value = Utils.Utilities.getCurrentDate();
            RubroService rubroService = new RubroService();
            categoriasComboBox.DataSource = rubroService.getAllRubros();
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
    }
}
