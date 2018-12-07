using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Publicacion_Ubicacion : DatabaseEntity
    {
        /*codigoPub, fechaEvento, tipoUbicacion, precio, cantidad*/
        public int codigoPublicacion { get; set; }
        public DateTime fechaEvento { get; set; }
        public int tipoUbicacion { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
    }
}
