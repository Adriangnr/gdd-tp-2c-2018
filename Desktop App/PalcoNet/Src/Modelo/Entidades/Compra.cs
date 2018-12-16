using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Publicacion { get; set; }
        public string Direccion { get; set; }
        public double MontoTotal { get; set; }
        public string Tarjeta { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteApellido { get; set; }

        public List<Entrada_Ticket> Entradas { get; set; }

        public Compra() 
        {
            this.Entradas = new List<Entrada_Ticket>();
        }

        public void addEntrada(Entrada_Ticket entrada)
        {
            this.Entradas.Add(entrada);
        }
    }
}
