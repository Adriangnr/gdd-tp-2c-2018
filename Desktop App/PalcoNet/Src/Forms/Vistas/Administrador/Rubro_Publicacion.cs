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
    public partial class Rubro_Publicacion : Master
    {
        private RubroService rubroService = (RubroService)ServiceFactory.GetService("Rubro");

        public Rubro_Publicacion()
        {
            InitializeComponent();
            this.list_rubros.DataSource = rubroService.getAllRubros();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previous.Show();
        }

        private void btnAgregarRubro_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Rubro rubro in this.list_rubros.Items)
                {
                    if(rubro.descripcion == this.txtNuevoRubro.Text)
                    {
                        MessageBox.Show("El rubro ya existe!", "Nuevo rubro.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtNuevoRubro.Text = "";
                        return;
                    }
                }

                Rubro newRubro = new Rubro(this.txtNuevoRubro.Text);
                rubroService.save(newRubro);
                this.txtNuevoRubro.Text = "";
                this.list_rubros.DataSource = null;
                this.list_rubros.DataSource = rubroService.getAllRubros();
                this.list_rubros.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el rubro!", "Nuevo rubro.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.list_rubros.SelectedIndex == -1)
                    MessageBox.Show("No se selecciono ningun rubro!", "Eliminar rubro.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach(Rubro rubro in this.list_rubros.SelectedItems)
                {
                    this.rubroService.delete(rubro);
                }

                this.list_rubros.DataSource = null;
                this.list_rubros.DataSource = rubroService.getAllRubros();
                this.list_rubros.Refresh();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error al eliminar rubro!", "Eliminar rubro.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
