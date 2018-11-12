using System;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Entidades
{
    class Rol_Usuario : DatabaseEntity
    {
        public string RolName { get; set; }
        public string Username { get; set; }

        public Rol_Usuario(string rolName, string username)
        {
            this.RolName = rolName;
            this.Username = username;
        }

        public void save()
        {
            try
            {
                this.spExecute(this.schema + ".SaveRolUsuario",
                new System.Collections.Generic.List<SqlParameter>
                {
                    new SqlParameter("@rolName", this.RolName),
                    new SqlParameter("@username", this.Username)
                });
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
