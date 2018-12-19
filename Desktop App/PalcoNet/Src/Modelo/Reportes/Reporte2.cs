using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Reportes
{
    public class Reporte2
    {
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteApellido { get; set; }
        public string ClienteDocTipo { get; set; }
        public string ClienteDocNum { get; set; }
        public int PuntosVencidos { get; set; }
    }
}
