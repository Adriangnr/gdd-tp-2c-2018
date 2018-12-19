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
        public string TipoDesc { get; set; }
        public int Fila { get; set; }
        public int Asiento { get; set; }
        public int TipoId { get; set; }
        public int cantSinNumerar { get; set; }
        public double Precio { get; set; }
        public bool sinNumerar { get; set; }
        public int Ocupados { get; set; }
        public bool facturada { get; set; }

        public int FechaEventoId { get; set; }
        public DateTime FechaEvento { get; set; }

        public Entrada() { }

        public Entrada( int UbicacionId, int Fila, int Asiento, Ubicacion Ubicacion)
        {
            this.UbicacionId = UbicacionId;
            this.Fila = Fila;
            this.Asiento = Asiento;
            this.TipoId = Ubicacion.tipo.id;
            this.TipoDesc = Ubicacion.tipo.descripcion;
            this.Precio = Ubicacion.precio;
            this.sinNumerar = Ubicacion.sinNumerar;
            this.Ocupados = Ubicacion.ocupados;
            this.cantSinNumerar = 0;
        }

        public bool EsIgual(Entrada entradaNueva)
        {
            return this.UbicacionId == entradaNueva.UbicacionId && this.Fila == entradaNueva.Fila && this.Asiento == entradaNueva.Asiento;
        }

        public override string ToString()
        {
            return TipoDesc;
        }
    }
}
