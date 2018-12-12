﻿using System;
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
        public double Precio { get; set; }

        public Entrada() { }

        public Entrada( int UbicacionId, int Fila, int Asiento, Ubicacion Ubicacion)
        {
            this.UbicacionId = UbicacionId;
            this.Fila = Fila;
            this.Asiento = Asiento;
            this.TipoId = Ubicacion.tipo.id;
            this.TipoDesc = Ubicacion.tipo.descripcion;
            this.Precio = Ubicacion.precio;
        }

        public bool EsIgual(Entrada entradaNueva)
        {
            return this.UbicacionId == entradaNueva.UbicacionId && this.Fila == entradaNueva.Fila && this.Asiento == entradaNueva.Asiento;
        }
    }
}
