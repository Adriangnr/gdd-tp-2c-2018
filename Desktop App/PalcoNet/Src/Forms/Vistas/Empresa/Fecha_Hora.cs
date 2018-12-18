using PalcoNet.Src.Excepciones;
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
            this.dateTimePicker_pubFecha.Value = Utils.Utilities.getCurrentDate();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btn_cargar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.parent.getFechasDataGrid().Rows.Count > 0)
                {
                    DateTime lastDateInserted = (DateTime)this.parent.getFechasDataGrid().Rows[this.parent.getFechasDataGrid().Rows.Count - 1].Cells[0].Value;
                    DateTime currentDate = DateTime.Parse(this.dateTimePicker_pubFecha.Value.ToString("yyyy-MM-dd") + " " + this.text_inicio.Text);
                    int compare = DateTime.Compare(currentDate, lastDateInserted);
                    if (compare <= 0)
                    {
                        MessageBox.Show("La fecha ingresada debe ser mayor a la ultima cargada!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                this.parent.AddFechaHora(this.dateTimePicker_pubFecha.Value.ToString("yyyy-MM-dd") + " " + this.text_inicio.Text);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Verifique la fecha ingresada!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
