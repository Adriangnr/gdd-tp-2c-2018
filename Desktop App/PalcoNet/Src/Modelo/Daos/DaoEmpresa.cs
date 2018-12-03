using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoEmpresa : DatabaseEntity
    {
        public void save(Empresa empresa)
        {
            try
            {
                this.spExecute(this.schema + ".SaveEmpresa", new List<SqlParameter>
            {
                    new SqlParameter("@empresa_razon_social", empresa.RazonSocial),
                    new SqlParameter("@empresa_ciudad", empresa.Ciudad),
                    new SqlParameter("@empresa_cuit", empresa.Cuit),
                    new SqlParameter("@empresa_usuario", empresa.Usuario)
            });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void update(Empresa empresa)
        {
            try
            {
                empresa.UsuarioObj.update();
                this.spExecute(this.schema + ".updateEmpresa", new List<SqlParameter>
                {
                    new SqlParameter("@id", empresa.Id),
                    new SqlParameter("@razonSocial", empresa.RazonSocial),
                    new SqlParameter("@cuit", empresa.Cuit),
                    new SqlParameter("@ciudad", empresa.Ciudad),
                    new SqlParameter("@usuario", empresa.Usuario)
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> Search(System.Windows.Forms.Control.ControlCollection filters)
        {
            return Search(filters, (typeof(Empresa)).Name);
        }

        public void modifyStatus(int empresaId)
        {
            try
            {
                this.spExecute(this.schema + ".ChangeEmpresaStatus", new List<SqlParameter>() { new SqlParameter("@id", empresaId) });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
