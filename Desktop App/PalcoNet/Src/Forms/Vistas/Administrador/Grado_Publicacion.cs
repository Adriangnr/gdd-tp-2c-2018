
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Grado_Publicacion : Master
    {
        private GradoService gradoService = (GradoService)ServiceFactory.GetService("Grado");

        public Grado_Publicacion()
        {
            InitializeComponent();
            this.dataGridGrados.DataSource = gradoService.GetAllGrados();
        }

        public void reload()
        {
            this.dataGridGrados.DataSource = null;
            this.dataGridGrados.DataSource = gradoService.GetAllGrados();
            this.dataGridGrados.Refresh();
            this.dataGridGrados.ClearSelection();
        }

        public bool gradoExist(string descripcion)
        {
            foreach(DataGridViewRow row in this.dataGridGrados.Rows)
            {
                if ((string)row.Cells[1].Value == descripcion)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAgregarGrado_Click(object sender, System.EventArgs e)
        {
            Grado_Publicacion_Detalle gradoDetalle = new Grado_Publicacion_Detalle();
            gradoDetalle.previous = this;
            gradoDetalle.Show();
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Grado_Publicacion_Detalle gradoDetalle = new Grado_Publicacion_Detalle();
            gradoDetalle.previous = this;
            gradoDetalle.setCurrent((Grado)this.dataGridGrados.CurrentRow.DataBoundItem);
            gradoDetalle.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Grado currentGrado = (Grado)this.dataGridGrados.CurrentRow.DataBoundItem;

                if( currentGrado.habilitado )
                    this.gradoService.delete( currentGrado );
                else
                    this.gradoService.habilitar( currentGrado );

                this.reload();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message, "Eliminar grado.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
