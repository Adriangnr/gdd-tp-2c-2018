using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Grado_Publicacion_Detalle : Master
    {
        private GradoService gradoService = (GradoService)ServiceFactory.GetService("Grado");
        private Grado current = null;

        public Grado_Publicacion_Detalle()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.gradoService.save(this.txtDescripcion.Text, Convert.ToDouble(this.txtComision.Text));
                this.Hide();
                ((Grado_Publicacion)this.previous).reload();
                this.previous.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void setCurrent(Grado current)
        {
            this.current = current;
        }

        private void Grado_Publicacion_Detalle_Load(object sender, EventArgs e)
        {
            if(this.current != null)
            {
                this.txtDescripcion.Text = this.current.descripcion;
                this.txtComision.Text = this.current.comision.ToString();
            }
            else
            {
                this.txtDescripcion.Text = "";
                this.txtComision.Text = "";
            }
        }
    }
}
