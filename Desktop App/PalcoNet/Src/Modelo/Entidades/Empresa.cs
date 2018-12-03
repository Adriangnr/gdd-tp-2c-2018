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

        public override string ToString()
        {
            return this.RazonSocial;
        }
    }
}
