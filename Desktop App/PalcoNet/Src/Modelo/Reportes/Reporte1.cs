using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Reportes
{
    public class Reporte1
    {
        [DisplayName("Mes-Año")]
        public string MesAnio { get; set; }
        public string CUIT { get; set; }
        [DisplayName("Razon Social")]
        public string RazonSocial { get; set; }
        [DisplayName("Cantidad sin vender")]
        public int CantidadSinVender { get; set; }
    }
}
