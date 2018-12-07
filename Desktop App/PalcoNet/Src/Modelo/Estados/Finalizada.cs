using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Src.Forms.Vistas.Empresa;

namespace PalcoNet.Src.Modelo.Estados
{
    public class Finalizada : Estado
    {
        public Finalizada()
        {
            this.modificarString = "Esta publicacion ya finalizo!";
            this.publicarString = "Esta publicacion ya finalizo!";
            this.finalizarString = "Esta publicacion ya finalizo!";
        }

        public override void detailControls(Publicacion_Detalle publicacion_Detalle)
        {
            Utils.Utilities.disableControls(publicacion_Detalle);
            Utils.Utilities.EnableControls(publicacion_Detalle.Controls[7]);
        }

        override public bool estaFinalizada() { return true; }

        public override string ToString()
        {
            return "Finalizada";
        }
    }
}
