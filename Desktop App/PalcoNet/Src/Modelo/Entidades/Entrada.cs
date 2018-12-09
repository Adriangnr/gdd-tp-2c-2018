using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Entrada
    {
        public int Id { get; set; }
        public int Compra { get; set; }
        public int UbicacionId { get; set; }
        public int Fila { get; set; }
        public int Asiento { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public Entrada() { }

        public Entrada( int UbicacionId, int Fila, int Asiento, Ubicacion Ubicacion)
        {
            this.UbicacionId = UbicacionId;
            this.Fila = Fila;
            this.Asiento = Asiento;
            this.Ubicacion = Ubicacion;
        }

        public bool EsIgual(Entrada entradaNueva)
        {
            return this.UbicacionId == entradaNueva.UbicacionId && this.Fila == entradaNueva.Fila && this.Asiento == entradaNueva.Asiento;
        }
    }
}
