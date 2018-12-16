using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoTotal { get; set; }
        public string Tarjeta { get; set; }
        public List<Entrada> Entradas { get; set; }

        public Compra(int id, DateTime fecha, double montoTotal, string tarjeta)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.MontoTotal = montoTotal;
            this.Tarjeta = tarjeta;
            this.Entradas = new List<Entrada>();
        }

        public void addEntrada(Entrada entrada)
        {
            this.Entradas.Add(entrada);
        }
    }
}
