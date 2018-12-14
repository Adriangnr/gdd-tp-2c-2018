using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoGrado : DatabaseEntity
    {
        public void save(Grado grado)
        {
            try
            {
                this.spExecute("ESECUELE.saveGrado", new List<SqlParameter>()
                {
                    new SqlParameter("@descripcion", grado.descripcion),
                    new SqlParameter("@comision", grado.comision)
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void update(Grado grado)
        {
            try
            {
                this.spExecute("ESECUELE.updateGrado", new List<SqlParameter>()
                {
                    new SqlParameter("@id", grado.id),
                    new SqlParameter("@descripcion", grado.descripcion),
                    new SqlParameter("@comision", grado.comision)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Grado grado)
        {
            try
            {
                this.spExecute("ESECUELE.deleteGrado", new List<SqlParameter>()
                {
                    new SqlParameter("@id", grado.id)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
