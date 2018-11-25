using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Modelo.Entidades
{
    class Cliente : DatabaseEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public string Cuil { get; set; }
        public string FechaNacimiento { get; set; }
        public string DatosTarjeta { get; set; }
        public string Usuario { get; set; }
        public string Habilitado { get; set; }
        public Usuario UsuarioObj { get; set; }


        public Cliente() { }

        public void save()
        {
            try
            {
                this.spExecute(this.schema+".SaveCliente", new List<SqlParameter>
            {
                    new SqlParameter("@cliente_nombre", this.Nombre),
                    new SqlParameter("@cliente_apellido", this.Apellido),
                    new SqlParameter("@cliente_tipo_doc", this.TipoDoc),
                    new SqlParameter("@cliente_num_doc", this.NumDoc),
                    new SqlParameter("@cliente_cuil", this.Cuil),
                    new SqlParameter("@cliente_fecha_nacimiento", this.FechaNacimiento),
                    new SqlParameter("@cliente_usuario", this.Usuario),
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

                foreach(Control field in filters)
                {
                    if(field.GetType() == typeof(TextBox))
                    {
                        string value = null;
                        if (field.Text != "") value = field.Text;
                        parameters.Add(new SqlParameter("@" + field.Name, value));
                    }
                }
                return this.spExecuteDataReader(this.schema + ".SearchClients", parameters);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
