using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    /*
        fact_id, fact_fecha, fact_empresa, fact_estado, fact_total, fact_forma_pago
    */
    public class Factura : DatabaseEntity
    {
        public int id {get; set;}
        public DateTime fecha { get; set; }
        public int empresa { get; set; }
        public int estado { get; set; }
        public decimal total { get; set; }
        public decimal totalComision { get; set; }
        public int formaPago { get; set; }
    }
}
