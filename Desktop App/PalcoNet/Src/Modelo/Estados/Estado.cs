﻿using System;
using System.Windows.Forms;

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
            MessageBox.Show(modificarString, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public virtual Estado publicar()
        {
            MessageBox.Show(publicarString, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public virtual Estado finalizar()
        {
            MessageBox.Show( finalizarString, "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public virtual bool estaFinalizada() { return false; }

    }
}