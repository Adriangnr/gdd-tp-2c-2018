
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Grado_Publicacion : Master
    {
        private GradoService gradoService = (GradoService)ServiceFactory.GetService("Grado");

        public Grado_Publicacion()
        {
            InitializeComponent();
            this.dataGridGrados.DataSource = gradoService.GetGrados();
        }

        public void reload()
        {
            this.dataGridGrados.DataSource = null;
            this.dataGridGrados.DataSource = gradoService.GetGrados();
            this.dataGridGrados.Refresh();
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
    }
}
