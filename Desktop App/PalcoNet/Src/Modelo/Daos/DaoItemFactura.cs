using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoItemFactura : DatabaseEntity
    {
        public int save(Item_Factura itemFactura)
        {
            try
            {
                return this.spExecuteScalar("ESECUELE.saveItemFactura", new List<SqlParameter>() {
                    new SqlParameter("@factura", itemFactura.facturaId),
                    new SqlParameter("@monto", itemFactura.monto),
                    new SqlParameter("@descripcion", itemFactura.descripcion),
                    new SqlParameter("@cantidad", itemFactura.cantidad),
                    new SqlParameter("@entrada", itemFactura.entrada),
                    new SqlParameter("@comision", itemFactura.comision)
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
