using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Reportes
{
    public class Reporte3
    {
        public string CUIL { get; set; } // Si el cuil es 'cuil', cambiar por 'No registrado'
        [DisplayName("Id Cliente")]
        public int ClienteId { get; set; } // Hay clientes que no tienen cuil
        [DisplayName("Nombre Cliente")]
        public string ClienteNombre { get; set; }
        [DisplayName("Apellido Cliente")]
        public string ClienteApellido { get; set; }
        public string CUIT { get; set; }
        [DisplayName("Empresa")]
        public string EmpresaRazonSocial { get; set; }
        [DisplayName("Cantidad compras")]
        public int CantidadComprada { get; set; }
    }
}
