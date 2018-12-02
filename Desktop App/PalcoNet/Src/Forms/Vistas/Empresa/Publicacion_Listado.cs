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

                Page currentPage = this.paginator.nextPage();

                List<object> objects = currentPage.GetItems();
                List<Publicacion> publicaciones = objects.Cast<Publicacion>().ToList();
                if(publicaciones.Count == 0)
                    MessageBox.Show("No se encontraron publicaciones cargadas para este usuario!", "Alerta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dataGridPublicaciones.DataSource = publicaciones;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
