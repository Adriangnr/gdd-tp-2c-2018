using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Daos
{
    class DaoCompra : DatabaseEntity
    {
        public List<List<Object>> getAllCompras(int cliente)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@cliente", cliente)
                };

                return this.spExecuteDataReader(this.schema + ".GetAllCompras", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<List<Object>> getCompra(int idCompra)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@compra", idCompra)
                };

                return this.spExecuteDataReader(this.schema + ".GetCompra", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
