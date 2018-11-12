using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Modelo.Entidades
{
    class Empresa : DatabaseEntity
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Ciudad { get; set; }
        public string Cuit { get; set; }
        public string Usuario { get; set; }

        public Empresa() {}

        public void save()
        {
            try
            {
                this.spExecute(this.schema+"SaveEmpresa", new List<SqlParameter>
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
    }
}
