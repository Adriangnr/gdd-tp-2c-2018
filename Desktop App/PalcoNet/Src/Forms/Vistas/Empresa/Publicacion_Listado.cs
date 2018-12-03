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
    public partial class Publicacion_Listado : Master
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
                this.paginator = new EmpresaPublicacionPaginator();
                this.paginator.ItemsPerPage = 10;
                EmpresaService empresaService = ((EmpresaService)ServiceFactory.GetService("Empresa"));

                this.paginator.Entity = empresaService.GetEmpresaFromUsername(this.usuario.Username);

                Page currentPage = this.paginator.NextPage();

                this.totalPaginas.Text = this.paginator.TotalPages.ToString();
                this.paginaActual.Text = "1";

                this.btn_previousPage.Enabled = false;
                this.btn_firstPage.Enabled = false;

                List<object> objects = currentPage.GetItems();
                List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

                if (publicaciones.Count == 0)
                {
                    MessageBox.Show("No se encontraron publicaciones cargadas para este usuario!", "Alerta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.btn_lastPage.Enabled = false;
                    this.btn_nextPage.Enabled = false;
                }
                else
                {
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
            createForm.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.dataGridPublicaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionó ninguna publicación!", "Editar publicación.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Publicacion_Detalle createForm = new Publicacion_Detalle(this);
                EmpresaService empresaService = (EmpresaService)ServiceFactory.GetService("Empresa");
                Publicacion publicacion = empresaService.GetPublicacion(this.usuario.Username,
                    (int)this.dataGridPublicaciones.CurrentRow.Cells[0].Value);
                createForm.Show();
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

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.NextPage();
            this.btn_previousPage.Enabled = true;
            this.btn_firstPage.Enabled = true;

            if(this.paginator.PageNumber == (this.paginator.TotalPages - 1))
            {
                this.btn_nextPage.Enabled = false;
                this.btn_lastPage.Enabled = false;
            }

            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.changeCount();
            this.dataGridPublicaciones.ClearSelection();
        }

        private void btn_firstPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.FirstPage();

            this.btn_nextPage.Enabled = true;
            this.btn_lastPage.Enabled = true;

            this.btn_previousPage.Enabled = false;
            this.btn_firstPage.Enabled = false;

            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.changeCount();
            this.dataGridPublicaciones.ClearSelection();
        }

        private void btn_previousPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.PreviousPage();

            this.btn_nextPage.Enabled = true;
            this.btn_lastPage.Enabled = true;

            if (this.paginator.PageNumber == 0)
            {
                this.btn_previousPage.Enabled = false;
                this.btn_firstPage.Enabled = false;
            }

            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.changeCount();
            this.dataGridPublicaciones.ClearSelection();
        }

        private void btn_lastPage_Click(object sender, EventArgs e)
        {
            Page currentPage = this.paginator.LastPage();
            this.btn_previousPage.Enabled = true;
            this.btn_firstPage.Enabled = true;

            this.btn_nextPage.Enabled = false;
            this.btn_lastPage.Enabled = false;

            List<object> objects = currentPage.GetItems();
            List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();

            this.dataGridPublicaciones.DataSource = null;
            this.dataGridPublicaciones.DataSource = publicaciones;
            this.changeCount();
            this.dataGridPublicaciones.ClearSelection();
        }

        private void changeCount()
        {
            this.paginaActual.Text = ((this.paginator.PageNumber + 1)).ToString();
        }
    }
}