using System;
using System.Collections.Generic;
using System.Data;

namespace PalcoNet.Modelo.Entidades
{
    public class Funcionalidad : DatabaseEntity
    {
        private readonly byte id;
        private readonly string nombre;
        private readonly string descripcion;
        // Este estado es para las funcionalidades en modificacion/creacion de roles
        private EstadoFuncionalidad estado;

        public Funcionalidad(byte id, String nombre, String descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado = EstadoFuncionalidad.SIN_CAMBIOS;
        }

        public byte GetId()
        {
            return this.id;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetDescripcion()
        {
            return this.descripcion;
        }


        public EstadoFuncionalidad GetEstado()
        {
            return this.estado;
        }

        public void SetEstado( EstadoFuncionalidad estado)
        {
            this.estado = estado;
        }

        public enum EstadoFuncionalidad : short
        {
            SIN_ESTADO,
            NUEVO_CREADO,
            SIN_CAMBIOS,
            NUEVO_AGREGADO,
            NUEVO_BORRADO
        }

        /*
         * Este override es para mostrar las descripciones en los CheckedListBox
         */
        public override string ToString()
        {
            return descripcion;
        }
    }
}
