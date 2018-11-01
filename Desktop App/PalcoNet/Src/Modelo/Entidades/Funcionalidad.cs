using System;
using System.Collections.Generic;

namespace PalcoNet.Modelo.Entidades
{
    class Funcionalidad : DatabaseEntity
    {
        private byte id;
        private string name;

        public Funcionalidad(byte id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public byte GetId()
        {
            return this.id;
        }

        public string GetNombre()
        {
            return this.name;
        }
    }
}
