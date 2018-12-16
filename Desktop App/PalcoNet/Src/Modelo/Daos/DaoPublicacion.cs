using PalcoNet.Src.Modelo.Entidades;
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

        public int update(Publicacion publicacion)
        {
            try
            {
                return this.spExecuteScalar("ESECUELE.updatePublicacion", new List<SqlParameter>()
                {
                    new SqlParameter("@id", publicacion.Codigo),
                    new SqlParameter("@fecha_inicio", publicacion.FechaPublicacion),
                    new SqlParameter("@descripcion", publicacion.Descripcion),
                    new SqlParameter("@rubro", publicacion.Rubro.codigo),
                    new SqlParameter("@direccion", publicacion.Direccion),
                    new SqlParameter("@grado", publicacion.Grado.id),
                    new SqlParameter("@empresa", publicacion.Empresa.Id),
                    new SqlParameter("@estado", publicacion.Estado.ToString())
                });
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

        public void saveDates(int publicacion, List<DateTime> fechas)
        {
            try
            {
                foreach (DateTime fecha in fechas)
                {
                    this.spExecute("ESECUELE.saveFechas", new List<SqlParameter>()
                    {
                        new SqlParameter("@codigoPub", publicacion),
                        new SqlParameter("@fecha", fecha)
                    });
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void deleteUbicaciones(int publicacion)
        {
            try
            {
                this.spExecute("ESECUELE.deleteUbicaciones", new List<SqlParameter>()
                {
                    new SqlParameter("@publicacion", publicacion)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteFechas(int publicacion)
        {
            try
            {
                this.spExecute("ESECUELE.deleteFechas", new List<SqlParameter>()
                {
                    new SqlParameter("@publicacion", publicacion)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveUbicacion(Ubicacion ubicacion)
        {
            try
            {
                this.spExecute("ESECUELE.saveUbicacion", new List<SqlParameter>()
                {
                   new SqlParameter("@publicacion", ubicacion.publicacion),
                   new SqlParameter("@filas", ubicacion.filas),
                   new SqlParameter("@asientos", ubicacion.asientos),
                   new SqlParameter("@precio", ubicacion.precio),
                   new SqlParameter("@sinNumerar", ubicacion.sinNumerar),
                   new SqlParameter("@ocupados", ubicacion.ocupados),
                   new SqlParameter("@tipo", ubicacion.tipo.id)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
