using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PalcoNet.Src.Modelo.Entidades;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoCompra : DatabaseEntity
    {
        public int getComprasOfEmpresa(int id)
        {
            try
            {
                return this.spExecuteScalar("ESECUELE.getComprasOfEmpresa",
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@empresaId", id)
                    });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
