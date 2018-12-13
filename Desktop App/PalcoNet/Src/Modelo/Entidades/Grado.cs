using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Grado
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descripción")]
        public string descripcion { get; set; }

        [DisplayName("Comisión")]
        public double comision { get; set; }

        public Grado() { }

        public Grado(string descripcion, double comision)
        {
            this.descripcion = descripcion;
            this.comision = comision;
        }

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