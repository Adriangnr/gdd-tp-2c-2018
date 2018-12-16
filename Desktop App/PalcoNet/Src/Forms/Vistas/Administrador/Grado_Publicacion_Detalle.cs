using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Validadores;
using System;
using System.Globalization;
using System.Windows.Forms;

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
                ValidadorGrado validador = new ValidadorGrado();
                validador.validar(this.Controls);

                if(this.current == null)
                {
                    if (((Grado_Publicacion)this.previous).gradoExist(this.txtDescripcion.Text))
                    {
                        MessageBox.Show("Ya existe un grado con esa descripción!", "Crear grado.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.gradoService.save(this.txtDescripcion.Text, Convert.ToDecimal(this.txtComision.Text));
                        this.Hide();
                        ((Grado_Publicacion)this.previous).reload();
                        this.previous.Show();
                    }
                }
                else
                {
                    this.current.comision = Convert.ToDecimal(this.txtComision.Text);
                    this.current.descripcion = this.txtDescripcion.Text;

                    this.gradoService.update(this.current);
                    this.Hide();
                    ((Grado_Publicacion)this.previous).reload();
                    this.previous.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message, "Crear grado.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
