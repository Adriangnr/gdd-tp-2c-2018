using System;
using System.ComponentModel;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class ItemDetail
    {
        [DisplayName("Código de compra")]
        public int codCompra { get; set; }

        [DisplayName("Código de publicación")]
        public int publicacion { get; set; }

        [DisplayName("Código de entrada")]
        public int entrada { get; set; }

        [DisplayName("Tipo de ubicación")]
        public string descripcionUbicacion { get; set; }

        [DisplayName("Fila")]
        public int fila { get; set; }

        [DisplayName("Asiento")]
        public int asiento { get; set; }

        [DisplayName("Fecha de evento")]
        public DateTime fechaEvento { get; set; }

        [DisplayName("Cantidad")]
        public int cantidad { get; set; }

        [DisplayName("Valor")]
        public decimal monto { get; set; }

        [DisplayName("Comisión")]
        public decimal comision { get; set; }
        

    }
}
