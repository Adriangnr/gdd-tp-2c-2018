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
        private Form form_ubicacion;
        List<Entrada> entradasCompradas = new List<Entrada>();

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
            this.form_ubicacion.Close();
            this.previous.Show();
            this.Close();
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {
            if (this.form_ubicacion == null)
            {
                Compra_Ubicacion compra_ubicacion = new Compra_Ubicacion(this, publicacion.Codigo, entradasCompradas);
                this.form_ubicacion = compra_ubicacion;
                compra_ubicacion.ShowDialog();
            }
            else
                this.form_ubicacion.ShowDialog();
            
        }

        public void load_entradas()
        {
            this.dataGridEntradasCompradas.DataSource = null;
            this.dataGridEntradasCompradas.DataSource = this.entradasCompradas;

            double precioTotal = 0.0;

            if (dataGridEntradasCompradas.DataSource != null && this.entradasCompradas.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridEntradasCompradas.Rows)
                {
                    Entrada entrada = row.DataBoundItem as Entrada;
                    precioTotal += entrada.Precio;
                }
            }

            this.label_total.Text = precioTotal.ToString();

            List<string> encabezados = new List<string>(new string[] { "TipoId", "Id", "Compra", "UbicacionId" });

            foreach (DataGridViewColumn column in this.dataGridEntradasCompradas.Columns)
            {
                if (encabezados.Contains(column.HeaderText))
                    column.Visible = false;
            }

            this.dataGridEntradasCompradas.AutoSize = false;
            this.dataGridEntradasCompradas.ScrollBars = ScrollBars.Both;
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            Entrada entrada = (Entrada)this.dataGridEntradasCompradas.CurrentRow.DataBoundItem;
            this.entradasCompradas.Remove(entrada);
            this.load_entradas();
        }
    }
}
