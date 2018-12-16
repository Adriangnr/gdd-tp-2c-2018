using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    class Entrada_Ticket
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Fila { get; set; }
        public string Asiento { get; set; }
        public double Precio { get; set; }
        public bool SinNumerar { get; set; }

        public Entrada_Ticket() { }
    }
}
