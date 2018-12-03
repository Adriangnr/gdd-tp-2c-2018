using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public partial class PaginatorControls : UserControl
    {
        Pageable form;

        public PaginatorControls(Pageable form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void PaginatorControls_Load(object sender, EventArgs e)
        {

        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            this.form.btn_nextPage_Click(sender, e);
        }

        private void btn_lastPage_Click(object sender, EventArgs e)
        {
            this.form.btn_lastPage_Click(sender, e);
        }

        private void btn_previousPage_Click(object sender, EventArgs e)
        {
            this.form.btn_previousPage_Click(sender, e);
        }

        private void btn_firstPage_Click(object sender, EventArgs e)
        {
            this.form.btn_firstPage_Click(sender, e);
        }
    }
}
