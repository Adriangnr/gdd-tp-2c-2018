using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Modelo.Entidades
{
    class Rol : DatabaseEntity
    {
        //attributes
        public byte Id { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }

        public Rol() { }

        public Rol(byte id)
        {
            List<List<object>> rows = this.Get("Rol", new List<SqlParameter> { new SqlParameter("@id", id) });
            List<object> row = rows[0];
            this.Id = (byte)row[0];
            this.Estado = (bool)row[2];
            this.Nombre = (string)row[1];
        }
    }
}
