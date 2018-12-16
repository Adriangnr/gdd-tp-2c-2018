using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Compra : DatabaseEntity
    {
        /*id, total, cliente, fecha, medio_de_pago*/
        public int id { get; set; }
        public decimal total { get; set; }
        public int clienteId { get; set; }
        public DateTime fecha { get; set; }
        public int medioDePago { get; set; }
        public int publicacion { get; set; }
    }
}
