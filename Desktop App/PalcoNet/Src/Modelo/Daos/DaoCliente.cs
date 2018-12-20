using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoCliente : DatabaseEntity
    {
        public void save(Cliente cliente)
        {
            try
            {
                this.spExecute(this.schema + ".SaveCliente", new List<SqlParameter>
            {
                    new SqlParameter("@cliente_nombre", cliente.Nombre),
                    new SqlParameter("@cliente_apellido", cliente.Apellido),
                    new SqlParameter("@cliente_tipo_doc", cliente.TipoDoc),
                    new SqlParameter("@cliente_num_doc", cliente.NumDoc),
                    new SqlParameter("@cliente_cuil", cliente.Cuil),
                    new SqlParameter("@cliente_fecha_nacimiento", cliente.FechaNacimiento),
                    new SqlParameter("@cliente_usuario", cliente.Usuario),
                    new SqlParameter("@cliente_tarjeta", cliente.DatosTarjeta),
            });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void update(Cliente cliente)
        {
            try
            {
                DaoUsuario daoUsuario = new DaoUsuario();
                daoUsuario.update(cliente.UsuarioObj);
                this.spExecute(this.schema + ".updateCliente", new List<SqlParameter>
                {
                    new SqlParameter("@id", cliente.Id),
                    new SqlParameter("@nombre", cliente.Nombre),
                    new SqlParameter("@apellido", cliente.Apellido),
                    new SqlParameter("@tipoDoc", cliente.TipoDoc),
                    new SqlParameter("@numDoc", cliente.NumDoc),
                    new SqlParameter("@cuil", cliente.Cuil),
                    new SqlParameter("@fechaNac", cliente.FechaNacimiento),
                    new SqlParameter("@usuario", cliente.Usuario),
                    new SqlParameter("@tarjeta", cliente.DatosTarjeta)
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<List<object>> Search(System.Windows.Forms.Control.ControlCollection filters)
        {
            return Search(filters, (typeof(Cliente)).Name);
        }

        public void modifyStatus(int clientId)
        {
            try
            {
                this.spExecute(this.schema + ".ChangeClientStatus", new List<SqlParameter>() { new SqlParameter("@id", clientId) });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateTarjeta(int clientId, string tarjeta)
        {
            try
            {
                this.spExecute(this.schema + ".UpdateClienteTarjeta", new List<SqlParameter>() { 
                    new SqlParameter("@id", clientId),
                    new SqlParameter("@tarjeta", tarjeta)});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getPuntaje(int idCliente)
        {
            return this.spExecuteScalar(this.schema + ".GetPuntaje", new List<SqlParameter> { 
            new SqlParameter("@cliente", idCliente),
            new SqlParameter("@fechaActual",Utils.Utilities.getCurrentDate())
            });
        }

        public int getPuntajeVencido(int idCliente)
        {
            return this.spExecuteScalar(this.schema + ".GetPuntajeVencido", new List<SqlParameter> { 
            new SqlParameter("@cliente", idCliente),
            new SqlParameter("@fechaActual",Utils.Utilities.getCurrentDate())
            });
        }
    }
}
