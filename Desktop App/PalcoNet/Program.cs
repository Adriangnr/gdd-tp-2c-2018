﻿using PalcoNet.Src.Forms.Vistas.Administrador;
using PalcoNet.Src.Forms.Vistas.General;
using System;
using System.Windows.Forms;

namespace PalcoNet
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Rol_Listado());
        }
    }
}
