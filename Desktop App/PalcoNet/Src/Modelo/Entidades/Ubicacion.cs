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
        public int publicacion { get; set; }
        public int filas { get; set; }
        public int asientos { get; set; }
        public double precio { get; set; }
        public bool sinNumerar { get; set; }
        public int ocupados { get; set; }
        public int tipo { get; set; }
        public string descripcion { get; set; }
        public int cantSinNumerar { get; set; }

        public Ubicacion() { }
    }
}
