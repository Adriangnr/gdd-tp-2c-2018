using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Usuario : DatabaseEntity
    {
        private int prepared = 0;
        private List<Rol> Roles = new List<Rol>();

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Habilitado { get; set; }
        public bool Nuevo { get; set; }
        public int Fallas { get; set; }
        public string FechaCreacion { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CodigoPostal { get; set; }

        //constructor por defecto para crear nuevos usuarios
        public Usuario(){}

        //constructor con parametros para traerme cierto usuario de la base
        public Usuario(String username)
        {
            List<List<object>> rows = this.Get("Usuario", new List<SqlParameter>
            {
                    new SqlParameter("@username", username)
            });

            rows.ForEach((row) => {
                if (this.prepared == 0)
                {
                    this.LoadAttributes(row);
                    this.prepared = 1;
                }
                this.addRol((byte)row[12]);
            });
        }

        public List<Rol> GetRoles()
        {
            return this.Roles;
        }

        public void addRol(byte rolId)
        {
            Rol rol = new Rol(rolId);
            this.Roles.Add(rol);
        }

        public void seleccionarRol(int id)
        {
            (this.Roles.Find(rol => rol.Id == id)).Seleccionado = true;
        }

        public Rol ObtenerRolSeleccionado()
        {
            return this.Roles.Find(rol => rol.Seleccionado == true);
        }

        public void save()
        {
            try
            {
                this.spExecute(this.schema+".SaveUsuario", new List<SqlParameter>
                {
                    new SqlParameter("@usr_username", this.Username),
                    new SqlParameter("@usr_pass", this.Password),
                    new SqlParameter("@usr_tipo", this.Tipo),
                    new SqlParameter("@usr_email", this.Email),
                    new SqlParameter("@usr_telefono", this.Telefono),
                    new SqlParameter("@usr_direccion", this.Direccion),
                    new SqlParameter("@usr_codigo_postal", this.CodigoPostal),
                });
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private void LoadAttributes(List<object> row)
        {
            this.Id = (int)row[0];
            this.Username = (string)row[1];
            this.Habilitado = (bool)row[3];
            this.Nuevo = (bool)row[4];
            this.Fallas = (byte)row[5];
            this.FechaCreacion = (row[6].GetType() != typeof(System.DBNull)) ? (string)row[6] : null;
            this.Tipo = (row[7].GetType() != typeof(System.DBNull)) ? (string)row[7] : null;
            this.Email = (row[8].GetType() != typeof(System.DBNull)) ? (string)row[8] : null;
            this.Telefono = (row[9].GetType() != typeof(System.DBNull)) ? (string)row[9] : null;
            this.Direccion = (row[10].GetType() != typeof(System.DBNull)) ? (string)row[10] : null;
        }
    }
}
