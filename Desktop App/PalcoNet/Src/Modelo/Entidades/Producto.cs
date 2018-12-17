using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public Producto() { }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
