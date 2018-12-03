using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoLogin : DatabaseEntity
    {
       public int GetLogin(String username, String password)
        {
            return this.spExecuteScalar("ESECUELE.Login", new List<SqlParameter>
            {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password_input", password)
            });
        }
    }
}
