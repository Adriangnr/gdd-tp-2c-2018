using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using PalcoNet.Src.Servicios.ServiceFactory;
using System.Data.SqlClient;
using PalcoNet.Src.Utils;

namespace PalcoNet.Src.Servicios
{
    class ClienteService : DatabaseService
    {
        public SortableBindingList<Cliente> Search(System.Windows.Forms.Control.ControlCollection filtros)
        {
            Cliente clienteSearchEntity = new Cliente();
            try
            {
                SortableBindingList<Cliente> clientes = new SortableBindingList<Cliente>();

                List <List<object>> results = clienteSearchEntity.Search(filtros);
             
                foreach (List<object> row in results){
                    Cliente clienteObj = new Cliente();
                    this.loadCliente(clienteObj, row);
                    clientes.Add(clienteObj);
                }
                return clientes;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public void loadUsuarioOfClient(Cliente clienteObj, List<object> row)
        {
            UsuarioService usuarioService = (UsuarioService)ServiceFactory.ServiceFactory.GetService("Usuario");
            clienteObj.UsuarioObj = usuarioService.LoadData(row,9);
            clienteObj.Habilitado = (clienteObj.UsuarioObj.Habilitado) ? "Si" : "No";
        }

        public void modifyStatus(int clientId)
        {
            try
            {
                Cliente clienteObj = new Cliente();
                clienteObj.modifyStatus(clientId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Cliente GetCliente(int id)
        {
            List<object> clientData = this.Get("Cliente", new List<SqlParameter> { new SqlParameter("@id", id) })[0];

            Cliente cliente = new Cliente();

            this.loadCliente(cliente, clientData);
            
            return cliente;
        }

        public void borrar(int id)
        {
            Cliente clienteObj = new Cliente();
            try
            {
                clienteObj.borrar(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void loadCliente(Cliente clienteObj, List<object> row)
        {
            clienteObj.Id = (int)row[0];
            clienteObj.Nombre = (string)row[1];
            clienteObj.Apellido = (string)row[2];
            clienteObj.TipoDoc = (string)row[3];
            clienteObj.NumDoc = (string)row[4];
            clienteObj.Cuil = (string)row[5];
            clienteObj.FechaNacimiento = ((DateTime)row[6]).ToString();
            clienteObj.Usuario = (string)row[8];
            clienteObj.Email = (string)row[17];
            this.loadUsuarioOfClient(clienteObj, row);
        }
    }
}
