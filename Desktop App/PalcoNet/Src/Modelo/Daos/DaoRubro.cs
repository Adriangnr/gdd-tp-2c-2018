using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoRubro : DatabaseEntity
    {
        public void save(Rubro rubro)
        {
            try
            {
                this.spExecute("ESECUELE.saveRubro", new List<SqlParameter>()
                {
                    new SqlParameter("@descripcion", rubro.descripcion)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Rubro rubro)
        {
            try
            {
                this.spExecute("ESECUELE.deleteRubro", new List<SqlParameter>()
                {
                    new SqlParameter("@codigo", rubro.codigo)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
