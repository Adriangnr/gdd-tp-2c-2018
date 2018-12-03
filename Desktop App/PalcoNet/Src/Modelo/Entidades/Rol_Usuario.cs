using System;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Rol_Usuario : DatabaseEntity
    {
        public string RolName { get; set; }
        public string Username { get; set; }

        public Rol_Usuario(string rolName, string username)
        {
            this.RolName = rolName;
            this.Username = username;
        }
    }
}
