using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Modelo.Entidades
{
    public class Rol : DatabaseEntity
    {
        //attributes
        private List<Funcionalidad> Funcionalidades = new List<Funcionalidad>();
        public byte Id { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public bool Seleccionado { get; set; }

        public Rol() { }

        public Rol(byte id)
        {
            List<List<object>> rows = this.Get("Rol", new List<SqlParameter> { new SqlParameter("@id", id) });
            List<object> row = rows[0];
            this.Id = (byte)row[0];
            this.Estado = (bool)row[2];
            this.Nombre = (string)row[1];
            this.Seleccionado = (rows.Count > 1) ? true : false;
            this.CargarFuncionalidades();
        }

        private void CargarFuncionalidades()
        {
            List<List<object>> rows = this.spExecuteDataReader("ESECUELE.ListarFuncionalidades",
                new List<SqlParameter> { new SqlParameter("@role", this.Id) });
            rows.ForEach(row =>
            {
                Funcionalidad func = new Funcionalidad((byte)row[0], (string)row[1], (string)row[2]);
                this.Funcionalidades.Add(func);
            });
        }

        public List<Funcionalidad> GetFuncionalidades()
        {
            return this.Funcionalidades;
        }

        public void AgregarFuncionalidad(Funcionalidad funcionalidad)
        {
            Funcionalidades.Add(funcionalidad);
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
