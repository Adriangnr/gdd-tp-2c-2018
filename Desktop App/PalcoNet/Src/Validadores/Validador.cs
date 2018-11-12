using PalcoNet.Src.Excepciones;
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
 
                 if(theMethod != null)
                {
                    Control[] methodParam = new Control[] { control };
                    try
                    {
                        theMethod.Invoke(this, methodParam);
                    }
                    catch(TargetInvocationException e)
                    {
                        throw e.InnerException;
                    }
                }
            }
        }
    }
}
