using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Publicacion_Detalle : Master
    {
        private PublicacionService publicacionService = (PublicacionService)ServiceFactory.GetService("Publicacion");
        private bool deleteButtonLoaded = false;

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

        private List<FechaHora> fechasHorarios = new List<FechaHora>();
        private List<EntradaString> entradas = new List<EntradaString>();

        public Publicacion_Detalle()
        {
            InitializeComponent();
            this.GetRubros();
            this.GetGrados();
        }

        public Publicacion_Detalle(Form previous)
        {
            this.previous = previous;
            InitializeComponent();
            this.GetRubros();
            this.GetGrados();
            this.GetEstados();
        }

        public void AddFechaHora(string fechaHoraString)
        {
            FechaHora fechahora =
                new FechaHora(DateTime.Parse(fechaHoraString));
            this.fechasHorarios.Add(fechahora);
            this.dataGridView_fechaHora.DataSource = null;
            this.dataGridView_fechaHora.DataSource = this.fechasHorarios;
            configureDatagridFechaHorarios();
            this.dataGridView_fechaHora.Refresh();
        }

        public void AddEntrada(string desc, string filas, string asientos, string precio, bool sinNumerar)
        {
            EntradaString entrada = new EntradaString(desc, filas, asientos, precio, sinNumerar);

            this.entradas.Add(entrada);
            this.dataGridView_tipoEntradas.DataSource = null;
            this.dataGridView_tipoEntradas.DataSource = this.entradas;
            this.dataGridView_tipoEntradas.ClearSelection();
        }

        public void loadFields(Publicacion publicacion)
        {
            this.descripcion.Text = publicacion.Descripcion;
            this.direccion.Text = publicacion.Direccion;
            foreach (object item in this.rubro.Items)
            {
                if(((Rubro)item).codigo == publicacion.Rubro.codigo) this.rubro.SelectedItem = item;
            }

            foreach (object item in this.grado.Items)
            {
                if (((Grado)item).id == publicacion.Grado.id) this.grado.SelectedItem = item;
            }

            foreach (object item in this.estado.Items)
            {
                if (((Estado)item).ToString() == publicacion.Estado.ToString()) this.estado.SelectedItem = item;
            }
            
            this.dataGridView_fechaHora.DataSource = null;
            List<FechaHora> horarios = this.publicacionService.getFechasDeEvento(publicacion.Codigo);
            this.fechasHorarios.AddRange(horarios);
            this.dataGridView_fechaHora.DataSource = this.fechasHorarios;
            configureDatagridFechaHorarios();
            this.dataGridView_fechaHora.Refresh();
        }

        public void addDeleteButton()
        {
            if (!this.deleteButtonLoaded)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                this.dataGridView_fechaHora.Columns.Add(btnDelete);
                this.deleteButtonLoaded = true;
            }
        }

        private void configureDatagridFechaHorarios()
        {
            try
            {
                  this.dataGridView_fechaHora.Columns[0].DefaultCellStyle.Format = "dd-MM-yyyy - HH:mm";
                  this.dataGridView_fechaHora.Refresh();
                this.addDeleteButton();
            }
            catch (Exception) { }
        }

        private void GetRubros()
        {
            RubroService rubroService = (RubroService)ServiceFactory.GetService("Rubro");
            this.rubro.Items.AddRange(rubroService.getAllRubros().ToArray());

        }

        private void GetGrados()
        {
            GradoService gradoService = (GradoService)ServiceFactory.GetService("Grado");
            this.grado.Items.AddRange(gradoService.GetGrados().ToArray());
        }

        private void GetEstados()
        {
            EstadoService estadoService = (EstadoService)ServiceFactory.GetService("Estado");
            this.estado.Items.AddRange(estadoService.GetEstados().ToArray());
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
            try
            {
                this.dataGridView_fechaHora.Columns.RemoveAt(2);
            }
            catch (Exception) { }
            
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
