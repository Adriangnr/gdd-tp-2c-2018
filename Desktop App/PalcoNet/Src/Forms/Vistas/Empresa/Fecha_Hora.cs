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
        class FechaHoraString
        {
            public string fechahora { get; set; }
            public string deleteButton { get; set; }

            public FechaHoraString(string value)
            {
                this.fechahora = value;
                this.deleteButton = "Eliminar";
            }
        }

        private List<FechaHoraString> fechasHorarios = new List<FechaHoraString>();

        public Fecha_Hora()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            FechaHoraString fechahora = 
                new FechaHoraString(this.dateTimePicker_pubFecha.Value.ToString() + 
                                    " - Inicia: " + this.text_inicio.Text + " - Finaliza: " + this.text_fin.Text);

            this.fechasHorarios.Add(fechahora);
            this.dataGridView_fechaHora.DataSource = null;
            this.dataGridView_fechaHora.DataSource = this.fechasHorarios;
            
        }

        private void dataGridView_fechaHora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                this.fechasHorarios.RemoveAt(e.RowIndex);
                this.dataGridView_fechaHora.DataSource = null;
                this.dataGridView_fechaHora.DataSource = this.fechasHorarios;
            }
        }
    }
}
