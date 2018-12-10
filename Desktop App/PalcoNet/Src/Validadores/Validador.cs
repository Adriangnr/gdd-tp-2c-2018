using PalcoNet.Src.Excepciones;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    public abstract class Validador
    {
        public void validar(Control.ControlCollection campos)
        {
            foreach (Control control in campos)
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

        protected void validarCampoTexto(TextBox campo, string descripcion, Regex patron)
        {
            if (!patron.IsMatch(campo.Text))
            {
                throw new ValidadorException("El campo " + descripcion + " posee caracteres invalidos!");
            }
        }
    }
}
