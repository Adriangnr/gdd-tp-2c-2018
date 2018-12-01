using PalcoNet.Src.Forms.Layouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        class EntradaString
        {
            public string Descripcion { get; set; }

            [DisplayName("Rango de Filas")]
            public string RangoFilas { get; set; }

            [DisplayName("Rango de Asientos")]
            public string RangoAsientos { get; set; }

            public string Precio { get; set; }

            [DisplayName("Sin Numerar")]
            public bool SinNumerar { get; set; }

            [DisplayName(" ")]
            public string deleteButton { get; set; }

            public EntradaString(string desc, string filas, string asientos, string precio, bool sinNumerar)
            {
                this.Descripcion = desc;
                this.RangoAsientos = asientos;
                this.RangoFilas = filas;
                this.Precio = precio;
                this.SinNumerar = sinNumerar;
                this.deleteButton = "Eliminar";
            }
        }

        private List<FechaHoraString> fechasHorarios = new List<FechaHoraString>();
        private List<EntradaString> entradas = new List<EntradaString>();

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

        public void AddEntrada(string desc, string filas, string asientos, string precio, bool sinNumerar)
        {
            EntradaString entrada = new EntradaString(desc, filas, asientos, precio, sinNumerar);

            this.entradas.Add(entrada);
            this.dataGridView_tipoEntradas.DataSource = null;
            this.dataGridView_tipoEntradas.DataSource = this.entradas;
            this.dataGridView_tipoEntradas.ClearSelection();
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
            entradas.parent = this;
            entradas.Show();
        }

        private void dataGridView_tipoEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.entradas.RemoveAt(e.RowIndex);
                this.dataGridView_tipoEntradas.DataSource = null;
                this.dataGridView_tipoEntradas.DataSource = this.entradas;
            }
        }
    }
}
