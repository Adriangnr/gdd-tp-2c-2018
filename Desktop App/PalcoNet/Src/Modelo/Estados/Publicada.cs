using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Modelo.Estados
{
    public class Publicada : Estado
    {
        public Publicada()
        {
            this.publicarString = "Esta publicación ya esta publicada!";
            this.modificarString = "Esta publicación ya fue publicada!";
        }

        override public bool estaPublicada() { return true; }

        override public Estado finalizar() { return new Finalizada(); }

        public override string ToString()
        {
            return "Publicada";
        } 
    }
}
