using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    class UserService : DatabaseService
    {
        public Usuario GetUser(String username)
        {
            return new Usuario(username);
        }

        public void save(Dictionary<string, string> userParams)
        {
            this.saveUserData(userParams);
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

        private void saveUserData(Dictionary<string, string> userParams)
        {
            Usuario usuario = new Usuario();
            usuario.Username = userParams["usr_username"];
            usuario.Password = userParams["usr_pass"];
            usuario.Tipo = userParams["usr_tipo"];
            usuario.Email = userParams["usr_email"];
            usuario.Telefono = userParams["usr_telefono"];
            usuario.Direccion = userParams["usr_direccion"];
            usuario.Direccion = userParams["usr_codigo_postal"];
            try
                {
                usuario.save();
                this.saveType(userParams);
                }
                catch(Exception e)
                {
                    throw e;
                }
        }
    }
}
