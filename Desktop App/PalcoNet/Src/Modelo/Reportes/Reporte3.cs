using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Reportes
{
    public class Reporte3
    {
        public string CUIL { get; set; } // Si el cuil es 'cuil', cambiar por 'No registrado'
        public int ClienteId { get; set; } // Hay clientes que no tienen cuil
        public string ClienteNombre { get; set; }
        public string ClienteApellido { get; set; }
        public string Empresa { get; set; }
        public int CantidadComprada { get; set; }
    }
}
