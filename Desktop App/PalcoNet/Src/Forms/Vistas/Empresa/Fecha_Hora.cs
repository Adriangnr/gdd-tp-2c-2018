using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Fecha_Hora : Form
    {
        public Publicacion_Detalle parent { get; set; }

        public Fecha_Hora()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btn_cargar_Click_1(object sender, EventArgs e)
        {
            this.parent.AddFechaHora(this.dateTimePicker_pubFecha.Value.ToString("yyyy-MM-dd") + " " +this.text_inicio.Text);
        }
    }
}
