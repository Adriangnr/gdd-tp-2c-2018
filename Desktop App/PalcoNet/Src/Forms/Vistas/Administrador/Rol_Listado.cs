using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
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
    public partial class Rol_Listado : Master
    {
        public Rol_Listado()
        {
            InitializeComponent();
        }

        private void Rol_Listado_Load(object sender, EventArgs e)
        {
            actualizarListadoRoles();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            new Rol_Creacion(this).Show();
            Hide();
        }

        public void actualizarListadoRoles()
        {
            RolService rolService = (RolService)ServiceFactory.GetService("Rol");
            this.dataGridRoles.DataSource = rolService.getAllRoles();

            List<string> encabezados = new List<string>(new string[] { "Funcionalidades", "Seleccionado"});
            List<string> autoCells = new List<string>(new string[] { });

            foreach (DataGridViewColumn column in this.dataGridRoles.Columns)
            {
                if (encabezados.Contains(column.HeaderText))
                    column.Visible = false;

                if (autoCells.Contains(column.HeaderText))
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            this.dataGridRoles.AutoSize = false;
            this.dataGridRoles.ScrollBars = ScrollBars.Both;
            this.dataGridRoles.ClearSelection();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.dataGridRoles.SelectedRows.Count == 0)
                MessageBox.Show("Debe seleccionr un rol!", "Listado roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Rol_Detalle rolDetalle = new Rol_Detalle(this, (Rol)dataGridRoles.CurrentRow.DataBoundItem);
                rolDetalle.previous = this;
                rolDetalle.Show();
                Hide();
            }
        }

    }
}
