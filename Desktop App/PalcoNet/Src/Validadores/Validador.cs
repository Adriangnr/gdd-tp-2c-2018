using System;
using System.Reflection;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    abstract class Validador
    {
        public void validar(Form registro)
        {
            foreach (Control control in registro.Controls)
            {
                MethodInfo theMethod = this.GetType().GetMethod(control.Name);

                if (control.GetType() == typeof(GroupBox))
                {
                    foreach(Control groupboxControl in control.Controls)
                    {

                    }
                }
                 
                 if(theMethod == null)
                {
                    Console.WriteLine("Tipo de control: " + control.GetType());
                    Console.WriteLine("No existe este  metodo -> "+control.Name);
                }
                else
                {
                    theMethod.Invoke(this, null);
                }
            }
        }
    }
}
