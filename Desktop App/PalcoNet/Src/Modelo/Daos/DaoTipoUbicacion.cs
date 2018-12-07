using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoTipoUbicacion : DatabaseEntity
    {
        public List<List<object>> getTiposUbicaciones()
        {
            return this.spExecuteDataReader(this.schema + ".getTiposUbicaciones", new List<SqlParameter>());
        }
    }
}
