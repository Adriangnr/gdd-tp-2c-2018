using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Validadores
{
    public class ValidadorReporte: Validador
    {
        public void textBox_anio(TextBox anio)
        {
            this.validarCampoTexto(anio, "Año", new Regex(@"^[0-9]{4}$"));
        }

        public void textBox_trimestre(TextBox trimestre)
        {
            this.validarCampoTexto(trimestre, "Trimestre", new Regex(@"^[1-4]{1}$"));
        }
    }
}
