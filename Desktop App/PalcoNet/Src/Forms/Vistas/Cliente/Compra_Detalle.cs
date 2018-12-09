using PalcoNet.Src.Forms.Layouts;
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
        public Compra_Detalle(Form previuos)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void Compra_Detalle_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {

        }
    }
}
