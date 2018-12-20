using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Rol : DatabaseEntity
    {
        //attributes
        private List<Funcionalidad> Funcionalidades;
        public byte Id { get; set; }
        public string Nombre { get; set; }
        public bool Seleccionado { get; set; }
        [DisplayName("Habilitado")]
        public bool Estado { get; set; }

        public Rol() {
            this.Funcionalidades = new List<Funcionalidad>();
        }

        public Rol(byte id)
        {
            this.Funcionalidades = new List<Funcionalidad>();
            List<List<object>> rows = this.Get("Rol", new List<SqlParameter> { new SqlParameter("@id", id) });
            List<object> row = rows[0];
            this.Id = (byte)row[0];
            this.Estado = (bool)row[2];
            this.Nombre = (string)row[1];
            this.Seleccionado = false;
            this.CargarFuncionalidades();
        }

        public Rol(byte id, String nombre, bool estado)
        {
            this.Funcionalidades = new List<Funcionalidad>();
            this.Id = id;
            this.Nombre = nombre;
            this.Estado = estado;
        }

        public void CargarFuncionalidades()
        {
            List<List<object>> rows = this.spExecuteDataReader("ESECUELE.getFuncionalidades",
                new List<SqlParameter> { new SqlParameter("@role", this.Id) });
            rows.ForEach(row =>
            {
                Funcionalidad func = new Funcionalidad((byte)row[0], (string)row[1], (string)row[2]);
                func.SetEstado(Funcionalidad.EstadoFuncionalidad.SIN_CAMBIOS);
                this.Funcionalidades.Add(func);
            });
        }

        public List<Funcionalidad> GetFuncionalidades()
        {
            if (Funcionalidades.Count == 0)
                CargarFuncionalidades();
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
