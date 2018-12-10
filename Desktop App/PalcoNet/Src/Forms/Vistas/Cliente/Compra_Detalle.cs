using System;
using PalcoNet.Src.Forms.Layouts;
using PalcoNet.Src.Modelo.Entidades;

namespace PalcoNet.Src.Forms.Vistas.Cliente
{
    public partial class Compra_Detalle : Master
    {
        private Compra compra;
        private Publicacion dataBoundItem;

        public Compra_Detalle(Compra compra, Publicacion dataBoundItem)
        {
            this.compra = compra;
            this.dataBoundItem = dataBoundItem;
        }

        public void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}