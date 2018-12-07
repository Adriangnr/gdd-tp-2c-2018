using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Publicacion_Detalle : Master
    {
        private PublicacionService publicacionService = (PublicacionService)ServiceFactory.GetService("Publicacion");
        public Publicacion publicacion { set; get; }

        public Publicacion_Detalle()
        {
            InitializeComponent();
            this.loadLists();
        }

        public Publicacion_Detalle(Form previous)
        {
            this.previous = previous;
            InitializeComponent();
            this.loadLists();
        }

        public void AddFechaHora(string fechaHoraString)
        {
            FechaHora fechahora =
                new FechaHora(DateTime.Parse(fechaHoraString));

            this.dataGridView_fechaHora.Rows.Add(fechahora.fechaHora, "Quitar");

            this.dataGridView_fechaHora.Refresh();
        }

        public void AddUbicacion(Ubicacion newUbicacion)
        {
            this.dataGridViewUbicaciones.Rows.Add(newUbicacion.descripcion, newUbicacion.fila, 
                newUbicacion.asiento, newUbicacion.precio, newUbicacion.cantidad, "Quitar");
        }

        public void loadFields()
        {
            this.descripcion.Text = this.publicacion.Descripcion;
            this.direccion.Text = this.publicacion.Direccion;
            foreach (object item in this.rubro.Items)
            {
                if(((Rubro)item).codigo == this.publicacion.Rubro.codigo) this.rubro.SelectedItem = item;
            }

            foreach (object item in this.grado.Items)
            {
                if (((Grado)item).id == this.publicacion.Grado.id) this.grado.SelectedItem = item;
            }

            foreach (object item in this.estado.Items)
            {
                if (((Estado)item).ToString() == this.publicacion.Estado.ToString()) this.estado.SelectedItem = item;
            }
            
            this.addListFechaHora(this.publicacionService.getFechasDeEvento(this.publicacion.Codigo));
            this.addListUbicaciones(this.publicacionService.getUbicaciones(this.publicacion.Codigo));
            this.publicacion.Estado.detailControls(this);
        }

        public void addListUbicaciones(List<Ubicacion> ubicaciones)
        {
            foreach (Ubicacion ubicacion in ubicaciones)
            {
                this.AddUbicacion(ubicacion);
            }
            this.dataGridView_fechaHora.Refresh();
        }

        public void addListFechaHora(List<FechaHora> horarios)
        {
            foreach(FechaHora fechaHora in horarios)
            {
                this.dataGridView_fechaHora.Rows.Add(fechaHora.fechaHora, "Quitar");
            }
            this.dataGridView_fechaHora.Refresh();
        }
        private void loadLists(){
            this.GetRubros();
            this.GetGrados();
            this.GetEstados();
        }

        private void GetUbicaciones()
        {
            UbicacionService ubicacionService = (UbicacionService)ServiceFactory.GetService("Ubicacion");
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
                this.dataGridView_fechaHora.Rows.RemoveAt(e.RowIndex);
                this.dataGridView_fechaHora.Refresh();
            }
        }

        private void dataGridView_tipoEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCargarUbicaciones_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicaciones = new Ubicaciones();
            ubicaciones.parent = this;
            ubicaciones.Show();
        }

        private void dataGridViewUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.dataGridViewUbicaciones.Rows.RemoveAt(e.RowIndex);
                this.dataGridViewUbicaciones.Refresh();
            }
        }
    }
}
