﻿using System;
using PalcoNet.Src.Forms.Vistas.Empresa;

namespace PalcoNet.Src.Modelo.Estados
{
    public class Borrador : Estado
    {
        public Borrador() { this.finalizarString = "Esta publicación aún esta en borrador!"; }

        public override bool puedeModificarse() { return true; }

        public override Estado publicar() { return new Publicada(); }
        
        public override string ToString()
        {
            return "Borrador";
        }

        public override void detailControls(Publicacion_Detalle publicacion_Detalle)
        {
            Utils.Utilities.EnableControls(publicacion_Detalle);
        }
    }
}
