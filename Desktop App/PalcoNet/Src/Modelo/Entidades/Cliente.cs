using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Cliente() { }

        public void save()
        {
            /*
                 userParams.Add("cliente_nombre", this.panel_roldata.Controls[0].Controls["nombre"].Text);
                userParams.Add("cliente_apellido", this.panel_roldata.Controls[0].Controls["apellido"].Text);
                userParams.Add("cliente_tipo_doc", this.panel_roldata.Controls[0].Controls["doc"].Text);
                userParams.Add("cliente_num_doc", this.panel_roldata.Controls[0].Controls["nrodoc"].Text);
                userParams.Add("cliente_cuil", this.panel_roldata.Controls[0].Controls["cuil"].Text);
                userParams.Add("cliente_fecha_nacimiento", this.panel_roldata.Controls[0].Controls["nacimiento"].Text);
                userParams.Add("cliente_datos_tarjeta", this.panel_roldata.Controls[0].Controls["tarjeta"].Text);
                userParams.Add("cliente_usuario", this.textBox_usuario.Text);
                 */
            try
            {
                this.spExecute("SaveCliente", new List<SqlParameter>
            {
                    new SqlParameter("@cliente_nombre", this.Nombre),
                    new SqlParameter("@cliente_apellido", this.Apellido),
                    new SqlParameter("@cliente_tipo_doc", this.TipoDoc),
                    new SqlParameter("@cliente_num_doc", this.NumDoc),
                    new SqlParameter("@cliente_cuil", this.Cuil),
                    new SqlParameter("@cliente_fecha_nacimiento", this.FechaNacimiento),
                    new SqlParameter("@cliente_datos_tarjeta", this.DatosTarjeta),
                    new SqlParameter("@cliente_usuario", this.Usuario),
            });
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
