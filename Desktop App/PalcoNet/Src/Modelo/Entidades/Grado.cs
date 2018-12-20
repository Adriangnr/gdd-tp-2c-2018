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
        public decimal comision { get; set; }

        [DisplayName("Habilitado")]
        public bool habilitado { get; set; }

        public Grado() { }

        public Grado(string descripcion, decimal comision)
        {
            this.descripcion = descripcion;
            this.comision = comision;
        }

        public Grado(int id, string descripcion, decimal comision)
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