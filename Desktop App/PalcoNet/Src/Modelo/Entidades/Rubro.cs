using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Rubro
    {
        private int codigo { get; set; }
        private string descripcion { get; set; }

        public Rubro(int codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
