using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Forms.Vistas.Paginador;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Publicacion_Listado : Master, Pageable
    {
        public Paginator paginator { get; set; }
        List<Publicacion> publicaciones;

        public Publicacion_Listado()
        {
            InitializeComponent();
        }

        private void loadPaginator()
        {
            this.paginator = new EmpresaPublicacionPaginator(this);
            this.paginator.ItemsPerPage = 10;
            EmpresaService empresaService = ((EmpresaService)ServiceFactory.GetService("Empresa"));

            this.paginator.Entity = empresaService.GetEmpresaFromUsername(this.usuario.Username);
        }

        private void getPage()
        {
            Page currentPage = this.paginator.NextPage();

            this.panelPaginatorControls.Controls.Add(this.paginator.controls);

            List<object> objects = currentPage.GetItems();
            this.publicaciones = objects.Cast<Publicacion>().ToList();
        }

        private void Pulicacion_Listado_Load(object sender, EventArgs e)
        {
            try
            {
                this.loadPaginator();
                this.getPage();

                if (this.publicaciones.Count == 0)
                {
                    MessageBox.Show("No se encontraron publicaciones cargadas para este usuario!", "Alerta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.dataGridPublicaciones.DataSource = null;
                    this.dataGridPublicaciones.DataSource = this.publicaciones;

                    List<string> esconder = new List<string>() { "FechaEvento", "FechaEventoId"};

                    foreach (DataGridViewColumn column in this.dataGridPublicaciones.Columns)
                    {

                        if (esconder.Contains(column.HeaderText))
                            column.Visible = false;
                    }
                    this.dataGridPublicaciones.ClearSelection();
                }
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

        private void Entidad_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Publicacion_Detalle createForm = new Publicacion_Detalle(this);
            createForm.setUsuario(this.usuario);
            createForm.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.dataGridPublicaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionó ninguna publicación!", "Editar publicación.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Publicacion_Detalle detailForm = new Publicacion_Detalle(this);
                Publicacion publicacion = (Publicacion)this.dataGridPublicaciones.CurrentRow.DataBoundItem;
                detailForm.publicacion = publicacion;
                detailForm.setUsuario(this.usuario);
                detailForm.loadFields();
                detailForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al editar publicación!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void btn_nextPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.NextPage();
            
            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.dataGridPublicaciones.ClearSelection();
        }

        public void btn_firstPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.FirstPage();
            
            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.dataGridPublicaciones.ClearSelection();
        }

        public void btn_previousPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.PreviousPage();
            
            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.dataGridPublicaciones.ClearSelection();
        }

        public void btn_lastPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.LastPage();
            
            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.dataGridPublicaciones.ClearSelection();
        }

        public void reload()
        {
            this.Pulicacion_Listado_Load(null, null);
        }

        private void dataGridPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Publicacion currentPublicacion = (Publicacion)this.dataGridPublicaciones.SelectedRows[0].DataBoundItem;
            if (!currentPublicacion.Estado.puedeModificarse())
            {
                this.btn_edit.Text = "Ver";
                this.btnFinalizar.Visible = true;
            }
            else
            {
                this.btn_edit.Text = "Editar";
                if(currentPublicacion.FechaEvento < Utils.Utilities.getCurrentDate()) this.btnFinalizar.Visible = false;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente quiere finalizar esta publicación?", 
                "Finalizar Publicación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Publicacion currentPublicacion = (Publicacion)this.dataGridPublicaciones.SelectedRows[0].DataBoundItem;
                    PublicacionService publicacionService = new PublicacionService();
                    currentPublicacion.Estado = new Finalizada();
                    publicacionService.update(currentPublicacion, null, null);
                    MessageBox.Show("Publicacion finalizada con exito!", "Finalizar publicación.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Pulicacion_Listado_Load(null, null);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("Error al finalizar la publicación!", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}