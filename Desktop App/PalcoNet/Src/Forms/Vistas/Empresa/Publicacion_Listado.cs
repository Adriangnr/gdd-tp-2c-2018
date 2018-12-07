using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Forms.Vistas.Paginador;
using PalcoNet.Src.Modelo.Entidades;
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

        public Publicacion_Listado()
        {
            InitializeComponent();
        }

        private void Pulicacion_Listado_Load(object sender, EventArgs e)
        {
            try
            {
                this.paginator = new EmpresaPublicacionPaginator(this);
                this.paginator.ItemsPerPage = 10;
                EmpresaService empresaService = ((EmpresaService)ServiceFactory.GetService("Empresa"));

                this.paginator.Entity = empresaService.GetEmpresaFromUsername(this.usuario.Username);

                Page currentPage = this.paginator.NextPage();

                this.panelPaginatorControls.Controls.Add(this.paginator.controls);
                
                List<object> objects = currentPage.GetItems();
                List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

                if (publicaciones.Count == 0)
                {
                    MessageBox.Show("No se encontraron publicaciones cargadas para este usuario!", "Alerta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.dataGridPublicaciones.DataSource = null;
                    this.dataGridPublicaciones.DataSource = publicaciones;
                    this.dataGridPublicaciones.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            this.Hide();
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
                System.Drawing.Size size = new System.Drawing.Size(1100, 500);
                detailForm.Size = size;
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

        private void dataGridPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Publicacion currentPublicacion = (Publicacion)this.dataGridPublicaciones.SelectedRows[0].DataBoundItem;
            if (!currentPublicacion.Estado.puedeModificarse())
            {
                this.btn_edit.Text = "Ver";
            }
            else
            {
                this.btn_edit.Text = "Editar";
            }
        }
    }
}