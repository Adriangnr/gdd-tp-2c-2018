using System;
using System.Collections.Generic;

namespace PalcoNet.Modelo.Entidades
{
    public class Funcionalidad : DatabaseEntity
    {
        private byte id;
        private string name;
        private string descripcion;

        public Funcionalidad(byte id, string name, string descripcion)
        {
            this.id = id;
            this.name = name;
            this.descripcion = descripcion;
        }

        public byte GetId()
        {
            return this.id;
        }

        public string GetNombre()
        {
            return this.name;
        }

        public string GetDescripcion()
        {
            return this.descripcion;
        }
    }
}
