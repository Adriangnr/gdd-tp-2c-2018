using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class Empresa : DatabaseEntity
    {
        public int Id { get; set; }

        [DisplayName("Razon Social")]
        public string RazonSocial { get; set; }

        public string Cuit { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Habilitado { get; set; }
        public string Ciudad { get; set; }
        public Usuario UsuarioObj { get; set; }

        public Empresa() {}

        public void save()
        {
            try
            {
                this.spExecute(this.schema+".SaveEmpresa", new List<SqlParameter>
            {
                    new SqlParameter("@empresa_razon_social", this.RazonSocial),
                    new SqlParameter("@empresa_ciudad", this.Ciudad),
                    new SqlParameter("@empresa_cuit", this.Cuit),
                    new SqlParameter("@empresa_usuario", this.Usuario)
            });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void update()
        {
            try
            {
                this.UsuarioObj.update();
                this.spExecute(this.schema + ".updateEmpresa", new List<SqlParameter>
                {
                    new SqlParameter("@id", this.Id),
                    new SqlParameter("@razonSocial", this.RazonSocial),
                    new SqlParameter("@cuit", this.Cuit),
                    new SqlParameter("@ciudad", this.Ciudad),
                    new SqlParameter("@usuario", this.Usuario)
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> Search(System.Windows.Forms.Control.ControlCollection filters)
        {
            return Search(filters, this.GetType().Name);
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

        public void borrar(int id)
        {
            try
            {
                this.spExecute(this.schema + ".borrarEmpresa", new List<SqlParameter>() { new SqlParameter("@id", id) });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<List<object>> GetPublicaciones()
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@id", this.Id)
                };

                return this.spExecuteDataReader(this.schema + ".getPublicacionesFromEmpresa", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> GetPublicacion(int code)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@idEmpresa", this.Id),
                    new SqlParameter("@codPub", code)
                };

                return this.spExecuteDataReader(this.schema + ".getPublicacion", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> SearchPagedPublicacionByEmpresa(int idEmpresa, int offset, int itemsPerPage)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@idEmpresa", idEmpresa),
                    new SqlParameter("@offset", offset),
                    new SqlParameter("@items", itemsPerPage)
                };

                return this.spExecuteDataReader(this.schema + ".SearchPagedPublicacionByEmpresa", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
