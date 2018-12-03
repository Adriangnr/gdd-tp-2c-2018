using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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

        public static DateTime getCurrentDate()
        {
            return DateTime.Parse(ConfigurationManager.AppSettings["FechaActual"]);
        }

        public static int getTamPagina()
        {
            return int.Parse(ConfigurationManager.AppSettings["TamPagina"]);
        }

        public bool fechaValida(DateTime fechaEvento)
        {
            return DateTime.Compare(fechaEvento, getCurrentDate()) >= 0;
        }

        public static string Hash(string input)
        {
            using (SHA256 hasher = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = hasher.ComputeHash(Encoding.Unicode.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("X2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }
    }
}
