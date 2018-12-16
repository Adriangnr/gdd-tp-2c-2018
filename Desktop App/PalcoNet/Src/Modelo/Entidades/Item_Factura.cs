using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    /*
        item_id, item_id_factura, item_monto, item_descripcion, item_cantidad, item_entrada
    */
    public class Item_Factura : DatabaseEntity
    {
        public int id { get; set; }
        public int facturaId { get; set; }
        public decimal monto { get; set; }
        public decimal comision { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public int entrada { get; set; }
    }
}
