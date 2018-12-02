using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Grado
    {
        private int id { get; set; }
        private string descripcion { get; set; }
        private double comision { get; set; }

        public Grado(int id, string descripcion, double comision)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.comision = comision;
        }
    }
}
