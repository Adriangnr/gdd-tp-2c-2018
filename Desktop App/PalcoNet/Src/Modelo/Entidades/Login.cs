using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Login : DatabaseEntity
    {
       public int GetLogin(String username, String password)
        {
            return this.spExecuteScalar("ESECUELE.Login", new List<SqlParameter>
            {
                    new SqlParameter("@username", username),
                    new SqlParameter("@plain_password", password)
            });
        }
    }
}
