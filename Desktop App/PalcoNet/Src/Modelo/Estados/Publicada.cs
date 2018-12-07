using System;
using System.Windows.Forms;
using PalcoNet.Src.Forms.Vistas.Empresa;

namespace PalcoNet.Src.Modelo.Estados
{
    public class Publicada : Estado
    {
        public Publicada()
        {
            this.publicarString = "Esta publicación ya esta publicada!";
            this.modificarString = "Esta publicación ya fue publicada!";
        }

        public override void detailControls(Publicacion_Detalle publicacion_Detalle)
        {
            Utils.Utilities.disableControls(publicacion_Detalle);
            Utils.Utilities.EnableControls(publicacion_Detalle.Controls[7]);
        }

        override public bool estaPublicada() { return true; }

        override public Estado finalizar() { return new Finalizada(); }

        public override string ToString()
        {
            return "Publicada";
        } 
    }
}
