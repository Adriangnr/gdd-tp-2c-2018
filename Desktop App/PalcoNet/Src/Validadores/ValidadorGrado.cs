using PalcoNet.Src.Excepciones;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    public class ValidadorGrado : Validador
    {
        public void txtDescripcion(TextBox descripcion)
        {
            if(descripcion.Text == "")
            {
                throw new ValidadorException("Debe ingresar el nombre del grado!");
            }
            else
            {
                this.validarCampoTexto(descripcion, "Descripcion", new Regex(@"^[a-zA-Z ]+$"));
            }
        }

        public void txtComision(TextBox comision)
        {
            if (comision.Text == "")
            {
                throw new ValidadorException("Debe ingresar la comision del grado!");
            }
            else
            {
                this.validarCampoTexto(comision, "Comision", new Regex(@"^\d+(\.{1}\d+)?$"));
            }
        }
    }
}
