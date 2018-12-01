using PalcoNet.Src.Forms.Layouts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Publicacion_Detalle : Master
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

        public Publicacion_Detalle()
        {
            InitializeComponent();
        }

        public Publicacion_Detalle(Form previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        public void AddFechaHora(string fechaHoraString)
        {
            FechaHoraString fechahora =
                new FechaHoraString(fechaHoraString);

            this.fechasHorarios.Add(fechahora);
            this.dataGridView_fechaHora.DataSource = null;
            this.dataGridView_fechaHora.DataSource = this.fechasHorarios;
            this.dataGridView_fechaHora.ClearSelection();
        }

        private void Publicacion_Detalle_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Hide();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.Utilities.clearForm(this.Controls);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_pub_cargarFechasHoras_Click(object sender, EventArgs e)
        {
            Fecha_Hora fechaHoraForm = new Fecha_Hora();
            fechaHoraForm.parent = this;
            fechaHoraForm.Show();
        }

        private void dataGridView_fechaHora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                this.fechasHorarios.RemoveAt(e.RowIndex);
                this.dataGridView_fechaHora.DataSource = null;
                this.dataGridView_fechaHora.DataSource = this.fechasHorarios;
            }
        }

        private void btn_pub_entradas_Click(object sender, EventArgs e)
        {
            Entradas entradas = new Entradas();
            entradas.Show();
        }
    }
}
