﻿using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Administrador
{
    public partial class Cliente_Registro : UserControl
    {
        public Cliente_Registro()
        {
            InitializeComponent();
            doc.Items.Add("DNI");
            doc.Items.Add("LC");
            doc.Items.Add("LE");
        }

        private void Cliente_Registro_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
