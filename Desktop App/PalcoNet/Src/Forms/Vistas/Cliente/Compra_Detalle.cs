using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra_Detalle : Master
    {
        private Publicacion publicacion;

        public Compra_Detalle(Form anterior, Publicacion publicacion)
        {
            this.previous = anterior;
            this.publicacion = publicacion;

            InitializeComponent();
        }

        private void Compra_Detalle_Load(object sender, EventArgs e)
        {
            this.label_espectaculo.Text = publicacion.Descripcion;
            this.label_fecha.Text = publicacion.FechaEvento.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {
            Compra_Ubicacion compra_ubicacion = new Compra_Ubicacion(this, publicacion.Codigo);
            compra_ubicacion.ShowDialog();
        }
    }
}
