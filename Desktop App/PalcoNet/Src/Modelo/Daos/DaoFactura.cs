﻿using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoFactura : DatabaseEntity
    {
        public int save(Factura factura)
        {
            try
            {
                return this.spExecuteScalar("ESECUELE.saveFactura", new List<SqlParameter>()
                {
                    new SqlParameter("@fecha", factura.fecha),
                    new SqlParameter("@empresa", factura.empresa),
                    new SqlParameter("@estado", factura.estado),
                    new SqlParameter("@total", factura.total),
                    new SqlParameter("@formaPago", factura.formaPago),
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
