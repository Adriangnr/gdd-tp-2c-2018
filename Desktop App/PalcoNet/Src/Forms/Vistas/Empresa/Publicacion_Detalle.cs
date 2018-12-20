﻿using PalcoNet.Src.Excepciones;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using PalcoNet.Src.Validadores;
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
            this.Size = new System.Drawing.Size(1200, 500);
            this.loadLists();
        }

        public void AddFechaHora(string fechaHoraString)
        {
            FechaHora fechahora =
                new FechaHora(DateTime.Parse(fechaHoraString));

            this.dataGridView_fechaHora.Rows.Add(fechahora.fechaHora, "Quitar");

            this.dataGridView_fechaHora.Refresh();
        }

        public void AddUbicacion(Dictionary<string, object> newUbicacion, bool esCreacion)
        {
            if (!this.ubicacionExists(((Tipo_Ubicacion)newUbicacion["descripcion"]).ToString(), (bool)newUbicacion["sinNumerar"]) || !esCreacion)
            {
                this.dataGridViewUbicaciones.Rows.Add(newUbicacion["descripcion"], newUbicacion["filas"],
                newUbicacion["asientos"], newUbicacion["precio"], newUbicacion["cantidad"], newUbicacion["sinNumerar"], "Quitar");
            }
            else
            {
                MessageBox.Show("La ubicación ingresada ya existe!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            
            this.addListFechaHora(this.publicacion.fechas);
            this.addListUbicaciones(this.publicacion.ubicaciones);
            this.publicacion.Estado.detailControls(this);
        }

        public void addListUbicaciones(List<Ubicacion> ubicaciones)
        {
            foreach (Ubicacion ubicacion in ubicaciones)
            {
                Dictionary<string, object> newUbicacion = new Dictionary<string, object>();

                Dictionary<string, object> ubicacionDic = new Dictionary<string, object>();
                ubicacionDic.Add("descripcion", ubicacion.tipo);
                ubicacionDic.Add("filas", ubicacion.filas);
                ubicacionDic.Add("asientos", ubicacion.asientos);
                ubicacionDic.Add("precio", ubicacion.precio);
                if(ubicacion.sinNumerar)
                {
                    ubicacionDic.Add("cantidad", ubicacion.asientos);
                }
                else
                {
                    ubicacionDic.Add("cantidad", ubicacion.filas * ubicacion.asientos);
                }
                ubicacionDic.Add("sinNumerar", ubicacion.sinNumerar);
                this.AddUbicacion(ubicacionDic, false);
            }
            this.dataGridView_fechaHora.Refresh();
        }

        public void addListFechaHora(List<DateTime> horarios)
        {
            foreach(DateTime fechaHora in horarios)
            {
                this.dataGridView_fechaHora.Rows.Add(fechaHora, "Quitar");
            }
            this.dataGridView_fechaHora.Refresh();
        }

        public DataGridView getFechasDataGrid()
        {
            return this.dataGridView_fechaHora;
        }

        private bool ubicacionExists(string desc, bool sinNumerar)
        {
            foreach(DataGridViewRow row in this.dataGridViewUbicaciones.Rows)
            {
                if((((Tipo_Ubicacion)row.Cells[0].Value).ToString() == desc) && ((bool)row.Cells[5].Value == sinNumerar))
                {
                    return true;
                }
            }
            return false;
        }

        private void loadLists(){
            this.GetRubros();
            this.GetGrados();
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

        private void Publicacion_Detalle_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
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
            this.Enabled = false;
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
            this.Enabled = false;
        }

        private void dataGridViewUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                this.dataGridViewUbicaciones.Rows.RemoveAt(e.RowIndex);
                this.dataGridViewUbicaciones.Refresh();
            }
        }

        private List<DateTime> getFechas()
        {
            List<DateTime> fechas = new List<DateTime>();
            
            foreach(DataGridViewRow row in this.dataGridView_fechaHora.Rows)
            {
                fechas.Add((DateTime)row.Cells[0].Value);
            }

            return fechas;
        }

        private List<Dictionary<string, object>> getUbicaciones()
        {
            List<Dictionary<string, object>> ubicaciones = new List<Dictionary<string, object>>();

            foreach(DataGridViewRow row in this.dataGridViewUbicaciones.Rows)
            {
                Dictionary<string, object> ubicacion = new Dictionary<string, object>();
                ubicacion.Add("descripcion", row.Cells[0].Value);
                ubicacion.Add("fila", row.Cells[1].Value);
                ubicacion.Add("asiento", row.Cells[2].Value);
                ubicacion.Add("precio", row.Cells[3].Value);
                ubicacion.Add("cantidad", row.Cells[4].Value);
                ubicacion.Add("sinNumerar", row.Cells[5].Value);

                ubicaciones.Add(ubicacion);
            }

            return ubicaciones;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorCargaPublicacion validador = new ValidadorCargaPublicacion();
                validador.validar(this.Controls);
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("FechaPublicacion", Utils.Utilities.getCurrentDate());
                data.Add("Descripcion", this.descripcion.Text);
                data.Add("Direccion", this.direccion.Text);
                data.Add("Rubro", (Rubro)this.rubro.SelectedItem);
                data.Add("Grado", (Grado)this.grado.SelectedItem);
                data.Add("Estado", new Borrador());
                data.Add("EmpresaId", this.usuario.getEmpresaId());
                if(this.publicacion == null)
                {
                    this.publicacionService.save(this.publicacionService.loadData(data), this.getFechas(), this.getUbicaciones());
                    MessageBox.Show("Publicacion cargada con exito!", "Cagar publicación.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.publicacion.Descripcion = this.descripcion.Text;
                    this.publicacion.Direccion = this.direccion.Text;
                    this.publicacion.Rubro = (Rubro)this.rubro.SelectedItem;
                    this.publicacion.Grado = (Grado)this.grado.SelectedItem;

                    this.publicacionService.update(this.publicacion, this.getFechas(), this.getUbicaciones());
                    MessageBox.Show("Publicacion actualizada con exito!", "Actualizar publicación.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ((Publicacion_Listado)this.previous).reload();
                this.previous.Show();
                this.Close();
                
            }
            catch(ValidadorException ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Error al guardar la publicación!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
