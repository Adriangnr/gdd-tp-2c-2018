using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Reportes
{
    public class Reporte2
    {
        [DisplayName("Id")]
        public int ClienteId { get; set; }
        public string CUIL { get; set; }
        [DisplayName("Nombre")]
        public string ClienteNombre { get; set; }
        [DisplayName("Apellido")]
        public string ClienteApellido { get; set; }
        [DisplayName("Puntos vencidos")]
        public int PuntosVencidos { get; set; }
    }
}
