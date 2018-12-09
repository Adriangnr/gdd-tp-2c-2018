using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Ubicacion
    {
        public int id { get; set; }
        public int fila { get; set; }
        public int asiento { get; set; }
        public double precio { get; set; }
        public int cantSinNumerar { get; set; }
        public bool sinNumerar { get; set; }

        public Ubicacion() { }
    }
}
