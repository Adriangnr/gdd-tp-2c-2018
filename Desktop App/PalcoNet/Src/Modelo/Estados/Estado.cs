using System;
using System.Windows.Forms;

namespace PalcoNet.Src.Modelo.Estados
{
    abstract class Estado
    {
        protected string publicarString;
        protected string modificarString;
        protected string finalizarString;

        public bool estaPublicada() { return false; }

        public bool puedeModificarse()
        {
            MessageBox.Show(modificarString, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public Estado publicar()
        {
            MessageBox.Show(publicarString, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public Estado finalizar()
        {
            MessageBox.Show( finalizarString, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public bool estaFinalizada() { return false; }

    }
}
