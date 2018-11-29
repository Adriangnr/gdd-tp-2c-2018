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
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                foreach (Control field in filters)
                {
                    if (field.GetType() == typeof(TextBox))
                    {
                        string value = null;
                        if (field.Text != "") value = field.Text;
                        parameters.Add(new SqlParameter("@" + field.Name, value));
                    }
                }
                return this.spExecuteDataReader(this.schema + ".SearchEmpresas", parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
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
