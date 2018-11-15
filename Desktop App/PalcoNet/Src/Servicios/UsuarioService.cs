using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    class UsuarioService : DatabaseService
    {
        public Usuario GetUser(String username)
        {
            return new Usuario(username);
        }

        public void save(Dictionary<string, string> userParams)
        {
            this.saveUserData(userParams);
        }

        public Usuario LoadData(List<object> data)
        {
            Usuario usuarioObj = new Usuario();
            usuarioObj.Id = (int)data[9];
            usuarioObj.Username = (string)data[10];
            usuarioObj.Password = System.Text.Encoding.UTF8.GetString((byte[])data[11]);
            usuarioObj.Habilitado = (bool)data[12];
            usuarioObj.Nuevo = (bool)data[13];
            usuarioObj.Email = (string)data[17];
            usuarioObj.Telefono = (data[18].GetType() != typeof(System.DBNull)) ? (string)data[18] : null;
            usuarioObj.Direccion = (string)data[19];
            usuarioObj.CodigoPostal = (string)data[20];

            return usuarioObj;
        }

        private void saveType(Dictionary<string, string> userParams)
        {
            if (userParams["usr_tipo"] == "Empresa")
            {
                Empresa empresa = new Empresa();
                empresa.RazonSocial = userParams["empresa_razon_social"];
                empresa.Ciudad = userParams["empresa_ciudad"];
                empresa.Cuit = userParams["empresa_cuit"];
                empresa.Usuario = userParams["empresa_usuario"];
                empresa.save();
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = userParams["cliente_nombre"];
                cliente.Apellido = userParams["cliente_apellido"];
                cliente.TipoDoc = userParams["cliente_tipo_doc"];
                cliente.NumDoc = userParams["cliente_num_doc"];
                cliente.Cuil = userParams["cliente_cuil"];
                cliente.FechaNacimiento = userParams["cliente_fecha_nacimiento"];
                cliente.DatosTarjeta = userParams["cliente_datos_tarjeta"];
                cliente.Usuario = userParams["cliente_usuario"];

                cliente.save();
            }
        }

        private void saveRoles(Dictionary<string, string> userParams)
        {
            Rol_Usuario rolUsuario = new Rol_Usuario(userParams["usr_tipo"], userParams["usr_username"]);
            rolUsuario.save();
        }

        private void saveUserData(Dictionary<string, string> userParams)
        {
            Usuario usuario = new Usuario();
            usuario.Username = userParams["usr_username"];
            usuario.Password = userParams["usr_pass"];
            usuario.Tipo = userParams["usr_tipo"];
            usuario.Email = userParams["usr_email"];
            usuario.Telefono = userParams["usr_telefono"];
            usuario.Direccion = userParams["usr_direccion"];
            usuario.CodigoPostal = userParams["usr_codigo_postal"];
            try
                {
                usuario.save();
                this.saveType(userParams);
                this.saveRoles(userParams);
                }
                catch(Exception e)
                {
                    usuario.delete();
                    throw e;
                }
        }
    }
}
