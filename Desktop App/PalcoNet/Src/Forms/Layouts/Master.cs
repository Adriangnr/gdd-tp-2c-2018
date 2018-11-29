using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Layouts
{
    public partial class Master : Form
    {
        public Form previous;
        public Usuario usuario;

        public Master()
        {
            InitializeComponent();
        }

        public void setPrevious(Form previous)
        {
            this.previous = previous;
        }

        public void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Master_Load(object sender, EventArgs e)
        {

        }
    }
}
