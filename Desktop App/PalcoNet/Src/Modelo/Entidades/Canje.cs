using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Canje
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }

        public Canje() { }
    }
}
