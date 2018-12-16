using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoItemFactura : DatabaseEntity
    {
        public void save(Item_Factura itemFactura)
        {
            try
            {
                this.spExecute("ESECUELE.saveItemFactura", new List<SqlParameter>() {
                    new SqlParameter(),
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
