using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Entrada_Ticket
    {
        [DisplayName("Numero de entrada")]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Fila { get; set; }
        public string Asiento { get; set; }
        public double Precio { get; set; }
        [DisplayName("Numeración")]
        public string SinNumerar { get; set; }

        public Entrada_Ticket() { }
    }
}
