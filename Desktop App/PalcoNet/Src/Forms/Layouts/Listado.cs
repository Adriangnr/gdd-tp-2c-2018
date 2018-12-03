using PalcoNet.Src.Utils;
using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Layouts
{
    public partial class Listado : Master
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {

        }

        protected void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.clearForm(this.Controls);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }
    }
}
