using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Entrada
    {
        /*id int, publicacion int, fila string, asiento string, sinNumerar bool, precio double, string tipo*/
        public int Id { get; set; }
        public int Publicacion { get; set; }
        public string Fila { get; set; }
        public string Asiento { get; set; }
        public bool SinNumerar { get; set; }
        public double Precio { get; set; }
        public string Tipo { get; set; }

        public Entrada() { }
    }
}
