using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Modelo.Estados
{
    class Finalizada : Estado
    {
        public Finalizada()
        {
            this.modificarString = "Esta publicacion ya finalizo!";
            this.publicarString = "Esta publicacion ya finalizo!";
            this.finalizarString = "Esta publicacion ya finalizo!";
        }

        override public bool estaFinalizada() { return true; }

        public override string ToString()
        {
            return "Finalizada";
        }
    }
}
