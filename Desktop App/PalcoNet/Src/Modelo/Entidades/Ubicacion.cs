using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public int Publicacion { get; set; }
        public int Cant_filas { get; set; }
        public int Cant_asientos { get; set; }
        public double Precio { get; set; }
        public bool Sin_numerar { get; set; }
        public int Cant_asientos_opcupados { get; set; }
        public int Tipo { get; set; }
        public string Tipo_descripcion { get; set; }

        public Ubicacion() { }
    }
}
