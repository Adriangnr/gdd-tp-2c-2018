using PalcoNet.Src.Excepciones;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Reportes;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Validadores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Estadisticas : Master
    {
        public Estadisticas()
        {
            InitializeComponent();

            this.cb_estadistica.DataSource = this.getReportes();
            this.cb_estadistica.SelectedIndexChanged += cb_estadistica_SelectedIndexChanged;

            this.label_fecha_actual.Text = Utils.Utilities.getCurrentDate().ToString();
        }

        void cb_estadistica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Reporte)cb_estadistica.SelectedItem).NumeroReporte == 1)
            {
                this.label_grado.Visible = true;
                this.cb_grado.Visible = true;
            }
            else
            {
                this.label_grado.Visible = false;
                this.cb_grado.Visible = false;
            }
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            GradoService gradoService = new GradoService();

            this.cb_grado.DataSource = gradoService.GetGrados();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorReporte validReg = new ValidadorReporte();
                validReg.validar(this.groupBox1.Controls);

                ReporteService reporteService = new ReporteService();

                int anio = int.Parse(this.textBox_anio.Text);
                int trimestre = int.Parse(this.textBox_trimestre.Text);

                switch (((Reporte)this.cb_estadistica.SelectedItem).NumeroReporte)
                {
                    case 1: 
                            this.dataGridEstadisticas.DataSource = 
                                reporteService.obtenerReporte1( anio, trimestre, (Grado)this.cb_grado.SelectedItem);
                            break;
                    case 2:
                            this.dataGridEstadisticas.DataSource =
                                reporteService.obtenerReporte2(anio, trimestre);
                            break;
                    case 3:
                            this.dataGridEstadisticas.DataSource =
                                reporteService.obtenerReporte3(anio, trimestre);
                            break;
                    default: break;
                }

            }
            catch (ValidadorException exception)
            {
                MessageBox.Show(exception.Message, "Error al obtener estadisticas.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al obtener estadisticas!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Reporte> getReportes()
        {
            return new List<Reporte> { 
                new Reporte("Empresas con mayor cantidad de localidades no vendidas", 1),
                new Reporte("Clientes con mayores puntos vencidos",2),
                new Reporte("Clientes con mayor cantidad de compras",3)
            };
        }
    }
}
