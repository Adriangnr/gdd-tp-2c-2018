using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Reportes
{
    public class Reporte1
    {
        public DateTime FechaEvento { get; set; }
        public string RazonSocial { get; set; }
        public int PublicacionId { get; set; }
        public string PublicacionDesc { get; set; }
        public string GradoDesc { get; set; }
        public int CantidadSinVender { get; set; }
    }
}
