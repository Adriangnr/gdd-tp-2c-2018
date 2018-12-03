using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Grado
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double comision { get; set; }

        public Grado() { }

        public Grado(int id, string descripcion, double comision)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.comision = comision;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}