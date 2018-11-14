using PalcoNet.Src.Excepciones;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace PalcoNet.Src.Validadores
{
    abstract class Validador
    {
        public void validar(ControlCollection campos)
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
            if (campo.Text == "")
            {
                throw new ValidadorException("El campo " + descripcion + " es requerido!");
            }
            else
            {
                if (!patron.IsMatch(campo.Text))
                {
                    throw new ValidadorException("El campo "+ descripcion +" posee caracteres invalidos!");
                }
            }
        }
    }
}
