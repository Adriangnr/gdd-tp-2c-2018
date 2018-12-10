using PalcoNet.Src.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    public class ValidadorCargaPublicacion : Validador
    {
        public void descripcion(TextBox descripcion)
        {
            this.validarCampoTexto(descripcion, "Descripcion", new Regex(@"^[a-zA-Z0-9\., ]+$"));
        }

        public void direccion(TextBox direccion)
        {
            this.validarCampoTexto(direccion, "Direccion", new Regex(@"^[a-zA-Z0-9\., ]+$"));
        }
        
        public void dataGridView_fechaHora(DataGridView fechaHora)
        {
            if(fechaHora.Rows.Count == 0)
            {
                throw new ValidadorException("Debe ingresar fechas y horarios para su espectaculo!");
            }
        }

        public void dataGridViewUbicaciones(DataGridView fechaHora)
        {
            if (fechaHora.Rows.Count == 0)
            {
                throw new ValidadorException("Ubicaciones para su espectaculo!");
            }
        }
    }
}
