﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Compra_Ticket
    {
        
        public int Id { get; set; }
        [DisplayName("Monto Total")]
        public double MontoTotal { get; set; }
        [DisplayName("Fecha Compra")]
        public DateTime Fecha { get; set; }
        public string Publicacion { get; set; }
        public string Direccion { get; set; }
        public string Tarjeta { get; set; }
        public int cantidadTotalPaginador { get; set; }

        public List<Entrada_Ticket> Entradas { get; set; }

        public Compra_Ticket() 
        {
            this.Entradas = new List<Entrada_Ticket>();
        }

        public void addEntrada(Entrada_Ticket entrada)
        {
            this.Entradas.Add(entrada);
        }
    }
}
