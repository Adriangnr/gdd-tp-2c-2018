using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Rol_Creacion : Layouts.Master
    {
        public Rol_Creacion()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if( String.IsNullOrWhiteSpace(textBox_nombre.Text))
            
                MessageBox.Show("Debe ingresar el nombre del nuevo rol.");


        }
    }
}
