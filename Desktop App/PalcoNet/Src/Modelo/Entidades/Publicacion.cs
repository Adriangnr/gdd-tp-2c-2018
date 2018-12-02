using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Publicacion : DatabaseEntity
    {
        /*int, date, string, date, int, string, int, int, string*/
        public int Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEvento { get; set; }
        public int Rubro { get; set; }
        public string Direccion { get; set; }
        public int Grado { get; set; }
        public int Empresa { get; set; }
        public string Estado { get; set; }

        public Publicacion() {}

        public List<List<object>> SearchActivasValidas(System.Windows.Forms.Control.ControlCollection filters)
        {
            return Search(filters, this.GetType().Name + "ActivaValida");
        }
    }
}
