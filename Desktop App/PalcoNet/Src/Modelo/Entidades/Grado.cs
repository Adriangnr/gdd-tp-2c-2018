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

        [DisplayName("Descripci�n")]
        public string descripcion { get; set; }

        [DisplayName("Comisi�n")]
        public decimal comision { get; set; }

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