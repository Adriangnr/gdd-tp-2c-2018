﻿using PalcoNet.Src.Modelo.Entidades;
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

namespace PalcoNet.Src.Forms.Vistas.Empresa
{
    public partial class Ubicaciones : Form
    {
        UbicacionService ubicacionService = (UbicacionService)ServiceFactory.GetService("Ubicacion");
        public Publicacion_Detalle parent { get; set; }

        public Ubicaciones()
        {
            InitializeComponent();
            this.comboBoxTipos.Items.AddRange(this.ubicacionService.getTiposUbicaciones().ToArray());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> newUbicacion = new Dictionary<string, object>();
            newUbicacion.Add("descripcion", this.comboBoxTipos.SelectedItem);
            newUbicacion.Add("tipo", (int)((Tipo_Ubicacion)this.comboBoxTipos.SelectedItem).id);
            newUbicacion.Add("filas", (string)this.txt_filas.Text);
            newUbicacion.Add("asientos", (string)this.txt_asientos.Text);
            newUbicacion.Add("precio", Convert.ToDouble(this.txt_precio.Text));
            newUbicacion.Add("cantidad", Convert.ToInt16(this.txt_cantidad.Text));

            this.parent.AddUbicacion(newUbicacion);
        }

        private void comboBoxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxTipos.SelectedItem.ToString() == "Sin Numerar")
            {
                this.txt_asientos.Enabled = false;
                this.txt_filas.Enabled = false;
            }
            else
            {
                this.txt_asientos.Enabled = true;
                this.txt_filas.Enabled = true;
            }
        }
    }
}
