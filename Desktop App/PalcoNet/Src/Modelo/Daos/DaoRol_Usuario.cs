using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoRol_Usuario : DatabaseEntity
    {
        public void save(Rol_Usuario rol_usuario)
        {
            try
            {
                this.spExecute(this.schema + ".SaveRolUsuario",
                new System.Collections.Generic.List<SqlParameter>
                {
                    new SqlParameter("@rolName", rol_usuario.RolName),
                    new SqlParameter("@username", rol_usuario.Username)
                });
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
