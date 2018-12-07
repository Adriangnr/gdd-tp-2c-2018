﻿using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoPublicacion : DatabaseEntity
    {
        public List<List<object>> SearchActivasValidas(System.Windows.Forms.Control.ControlCollection filters)
        {
            return Search(filters, "PublicacionActivaValida");
        }

        public List<List<object>> SearchPagedPublicacion(int offset, int itemsPerPage)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@offset", offset),
                    new SqlParameter("@items", itemsPerPage)
                };

                return this.spExecuteDataReader(this.schema + ".SearchPagedPublicacion", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> SearchPagedPublicacionesParaCompra(List<SqlParameter> parameters)
        {
            try
            {
                return this.spExecuteDataReader(this.schema + ".SearchPagedPublicacionesParaCompra", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> getFechas(int codigo)
        {
            try
            {
                return this.spExecuteDataReader(this.schema + ".GetFechasPublicacion", 
                    new List<SqlParameter>() { new SqlParameter("@codigo", codigo) });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> getUbicacionesDisponibles(int codigo)
        {
            try
            {
                return this.spExecuteDataReader(this.schema + ".GetUbicacionesDisponiblesPublicacion",
                    new List<SqlParameter>() { new SqlParameter("@codigo", codigo) });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int save(Publicacion publicacion)
        {
            try
            {
                return this.spExecuteScalar("ESECUELE.savePublicacion", new List<SqlParameter>()
                {
                    new SqlParameter("@fecha_inicio", publicacion.FechaPublicacion),
                    new SqlParameter("@descripcion", publicacion.Descripcion),
                    new SqlParameter("@fecha_evento", publicacion.FechaEvento),
                    new SqlParameter("@rubro", publicacion.Rubro.codigo),
                    new SqlParameter("@direccion", publicacion.Direccion),
                    new SqlParameter("@grado", publicacion.Grado.id),
                    new SqlParameter("@empresa", publicacion.getEmpresaId()),
                    new SqlParameter("@estado", publicacion.Estado.ToString())
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
