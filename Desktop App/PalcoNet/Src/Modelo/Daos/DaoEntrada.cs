using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Daos
{
    class DaoEntrada : DatabaseEntity
    {

        public List<List<object>> GetEntradasVendidas(int publicacion)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@publicacion_codigo", publicacion)
                };

                return this.spExecuteDataReader(this.schema + ".GetEntradasVendidas", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
