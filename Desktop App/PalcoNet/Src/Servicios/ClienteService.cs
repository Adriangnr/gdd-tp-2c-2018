using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using PalcoNet.Src.Servicios.ServiceFactory;
using System.Data.SqlClient;
using PalcoNet.Src.Utils;
using PalcoNet.Src.Modelo.Daos;

namespace PalcoNet.Src.Servicios
{
    class ClienteService : DatabaseService
    {
        DaoCliente daoCliente = new DaoCliente();

        public SortableBindingList<Cliente> Search(System.Windows.Forms.Control.ControlCollection filtros)
        {
            
            try
            {
                SortableBindingList<Cliente> clientes = new SortableBindingList<Cliente>();

                List <List<object>> results = this.daoCliente.Search(filtros);
             
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
                this.daoCliente.modifyStatus(clientId);
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

        public Cliente GetClienteByUsername(string username)
        {
            List<object> clientData = this.Get("ClienteByUsername", new List<SqlParameter> { new SqlParameter("@username", username) })[0];

            Cliente cliente = new Cliente();

            this.loadCliente(cliente, clientData);

            return cliente;
        }
        
        public void update(Cliente cliente)
        {
            try
            {
                this.daoCliente.update(cliente);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void loadCliente(Cliente clienteObj, List<object> row)
        {
            clienteObj.Id = (int)row[0];
            clienteObj.Nombre = (row[1].GetType() != typeof(DBNull)) ? (string)row[1] : "";
            clienteObj.Apellido = (row[2].GetType() != typeof(DBNull)) ? (string)row[2] : "";
            clienteObj.TipoDoc = (row[3].GetType() != typeof(DBNull)) ? (string)row[3] : "";
            clienteObj.NumDoc = (row[4].GetType() != typeof(DBNull)) ? (string)row[4] : "";
            clienteObj.Cuil = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : "";
            clienteObj.FechaNacimiento = (row[6].GetType() != typeof(DBNull)) ? ((DateTime)row[6]).ToString() : null;
            clienteObj.DatosTarjeta = (row[7].GetType() != typeof(DBNull)) ? (string)row[7]: null;
            clienteObj.Usuario = (string)row[8];
            clienteObj.Email = (row[17].GetType() != typeof(DBNull)) ? (string)row[17] : "";
            this.loadUsuarioOfClient(clienteObj, row);
        }

        public void updateTarjeta(int clienteId, string tarjeta)
        {
            this.daoCliente.updateTarjeta(clienteId, tarjeta);
        }
    }
}
