using System;
using System.Windows.Forms;
using PalcoNet.Src.Forms.Vistas.Empresa;

namespace PalcoNet.Src.Modelo.Estados
{
    public abstract class Estado
    {
        protected string publicarString;
        protected string modificarString;
        protected string finalizarString;

        public virtual bool estaPublicada() { return false; }

        public virtual bool puedeModificarse()
        {
            return false;
        }

        public virtual Estado publicar()
        {
            return null;
        }

        public virtual Estado finalizar()
        {
            return null;
        }

        public virtual bool estaFinalizada() { return false; }

        public abstract void detailControls(Publicacion_Detalle publicacion_Detalle);
    }
}
