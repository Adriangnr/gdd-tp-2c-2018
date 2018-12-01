﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Utils
{
    public class Utilities
    {
        public static Object createInstance(string classFullName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.CreateInstance(classFullName);
        }

        public static void clearForm(Control.ControlCollection campos)
        {
            foreach (Control control in campos)
            {
                if (control.GetType() == typeof(GroupBox))
                {
                    clearForm(control.Controls);
                }
                else if (control.GetType() == typeof(Panel))
                {
                    clearForm(control.Controls[0].Controls);
                }
                else if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
        }

        public static string getCurrentDate()
        {
            return ConfigurationManager.AppSettings["FechaActual"];
        }
    }
}
