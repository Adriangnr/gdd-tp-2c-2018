using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Reportes
{
    public class Reporte
    {
        public string Descripcion { get; set; }
        public int NumeroReporte { get; set; }


        public Reporte(string descripcion, int numero)
        {
            this.Descripcion = descripcion;
            this.NumeroReporte = numero;
        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
