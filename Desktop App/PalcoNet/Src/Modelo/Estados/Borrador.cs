using System;

namespace PalcoNet.Src.Modelo.Estados
{
    class Borrador : Estado
    {
        public Borrador() { this.finalizarString = "Esta publicación aún esta en borrador!"; }

        override public bool puedeModificarse() { return true; }

        override public Estado publicar() { return new Publicada(); }

        public override string ToString()
        {
            return "Borrador";
        }
    }
}
