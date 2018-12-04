using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    class UsuarioService : DatabaseService
    {
        private DaoUsuario daoUsuario = new DaoUsuario();
        private DaoRol_Usuario daoRolUsuario = new DaoRol_Usuario();

        public Usuario GetUser(String username)
        {
            return new Usuario(username);
        }

        public void save(Dictionary<string, string> userParams)
        {
            this.saveUserData(userParams);
        }

        public Usuario LoadData(List<object> data, int start)
        {
            Usuario usuarioObj = new Usuario();
            usuarioObj.Id = (int)data[start];
            usuarioObj.Username = (string)data[start+1];
            usuarioObj.Password = (string)data[start + 2];
            usuarioObj.Habilitado = (bool)data[start+3];
            usuarioObj.Nuevo = (bool)data[start+4];
            usuarioObj.Email = (string)data[start+8];
            usuarioObj.Telefono = (data[start+9].GetType() != typeof(System.DBNull)) ? (string)data[start+9] : null;
            usuarioObj.Direccion = (string)data[start+10];
            usuarioObj.CodigoPostal = (string)data[start+11];

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
                DaoEmpresa daoEmpresa = new DaoEmpresa();
                daoEmpresa.save(empresa);
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
                DaoCliente daoCliente = new DaoCliente();
                daoCliente.save(cliente);
            }
        }

        private void saveRoles(Dictionary<string, string> userParams)
        {
            Rol_Usuario rolUsuario = new Rol_Usuario(userParams["usr_tipo"], userParams["usr_username"]);
            this.daoRolUsuario.save(rolUsuario);
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
                this.daoUsuario.save(usuario);
                this.saveType(userParams);
                this.saveRoles(userParams);
            }
            catch(Exception e)
            {
                this.daoUsuario.delete(usuario);
                throw e;
            }
        }

        public void updatePassword(Usuario usuarioObj)
        {
            this.daoUsuario.updatePassword(usuarioObj);
        }

        public void cambioPassword(string username, string password)
        {
            this.daoUsuario.cambioPassword(username, password);
        }
    }
}
