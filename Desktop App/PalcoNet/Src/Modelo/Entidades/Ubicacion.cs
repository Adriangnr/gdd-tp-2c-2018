using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Ubicacion : DatabaseEntity
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int publicacion { get; set; }
        public string fila { get; set; }
        public string asiento { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public int disponible { get; set; }
        public int tipo { get; set; }
    }
}
