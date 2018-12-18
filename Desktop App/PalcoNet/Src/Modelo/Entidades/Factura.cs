using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Código")]
        public int id {get; set;}

        [DisplayName("Fecha")]
        public DateTime fecha { get; set; }

        public int empresa { get; set; }
        public int estado { get; set; }

        [DisplayName("Comision Total")]
        public decimal totalComision { get; set; }

        [DisplayName("Total")]
        public decimal total { get; set; }

        [DisplayName("Forma de Pago")]
        public int formaPago { get; set; }
    }
}
