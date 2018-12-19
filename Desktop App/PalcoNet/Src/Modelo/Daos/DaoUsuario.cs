using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Daos
{
    public class DaoUsuario : DatabaseEntity
    {
        public void delete(Usuario usuario)
        {
            try
            {
                this.spExecute(this.schema + ".DeleteUsuario", new List<SqlParameter> {
                    new SqlParameter("@usr_id", usuario.Id)
                });
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void save(Usuario usuario)
        {
            try
            {
                usuario.Id = this.spExecuteScalar(this.schema + ".SaveUsuario", new List<SqlParameter>
                {
                    new SqlParameter("@usr_username", usuario.Username),
                    new SqlParameter("@usr_pass", usuario.Password),
                    new SqlParameter("@usr_tipo", usuario.Tipo),
                    new SqlParameter("@usr_email", usuario.Email),
                    new SqlParameter("@usr_telefono", usuario.Telefono),
                    new SqlParameter("@usr_direccion", usuario.Direccion),
                    new SqlParameter("@usr_creacion", Utils.Utilities.getCurrentDate()),
                    new SqlParameter("@usr_codigo_postal", usuario.CodigoPostal),
                    new SqlParameter("@usr_primer_login", usuario.primerLogin),
                });
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void updatePassword(Usuario usuario)
        {
            try
            {
                this.spExecute(this.schema + ".updatePassUsuario", new List<SqlParameter>
                {
                    new SqlParameter("@id", usuario.Id),
                    new SqlParameter("@usr_pass", usuario.Password)
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cambioPassword(string username, string password)
        {
            try
            {
                this.spExecute(this.schema + ".cambioPassword", new List<SqlParameter>
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@new_password", Utils.Utilities.Hash(password))
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(Usuario usuario)
        {
            try
            {
                this.spExecute(this.schema + ".updateUsuario", new List<SqlParameter>
            {
                    new SqlParameter("@id", usuario.Id),
                    new SqlParameter("@username", usuario.Username),
                    new SqlParameter("@email", usuario.Email),
                    new SqlParameter("@telefono", usuario.Telefono),
                    new SqlParameter("@direccion", usuario.Direccion),
                    new SqlParameter("@cp", usuario.CodigoPostal)
            });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
