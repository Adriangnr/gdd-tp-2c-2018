using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PalcoNet.Src.Modelo.Entidades;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoCompra : DatabaseEntity
    {
        
        public int getCountComprasOfEmpresa(int id)
        {
            try
            {
                return this.spExecuteScalar("ESECUELE.getCountComprasOfEmpresa",
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

        public List<List<object>> getComprasComision(int top, int empresaId)
        {
            try
            {
                return this.spExecuteDataReader("ESECUELE.getComprasOfEmpresa",
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@top", top),
                        new SqlParameter("@empresaId", empresaId)
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<List<object>> getCompra(int id)
        {
            try
            {
                return this.spExecuteDataReader("ESECUELE.getCompra",
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@id", id)
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
