using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    class EmpresaService : DatabaseService
    {
        public List<Empresa> Search(System.Windows.Forms.Control.ControlCollection filtros)
        {
            Empresa empresaSearchEntity = new Empresa();
            try
            {
                List<Empresa> empresas = new List<Empresa>();

                List<List<object>> results = empresaSearchEntity.Search(filtros);

                foreach (List<object> row in results)
                {
                    Empresa empresaObj = new Empresa();
                    this.loadEmpresa(empresaObj, row);
                    empresas.Add(empresaObj);
                }
                return empresas;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void loadUsuario(Empresa empresaObj, List<object> row)
        {
            UsuarioService usuarioService = (UsuarioService)ServiceFactory.ServiceFactory.GetService("Usuario");
            empresaObj.UsuarioObj = usuarioService.LoadData(row, 5);
            empresaObj.Habilitado = (empresaObj.UsuarioObj.Habilitado) ? "Si" : "No";
        }

        public void modifyStatus(int clientId)
        {
            try
            {
                Empresa empresaObj = new Empresa();
                empresaObj.modifyStatus(clientId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Empresa GetEmpresa(int id)
        {
            List<object> clientData = this.Get("Empresa", new List<SqlParameter> { new SqlParameter("@id", id) })[0];

            Empresa empresa = new Empresa();

            this.loadEmpresa(empresa, clientData);

            return empresa;
        }

        private void loadEmpresa(Empresa empresaObj, List<object> row)
        {
            empresaObj.Id = (int)row[0];
            empresaObj.RazonSocial = (string)row[1];
            empresaObj.Ciudad = (row[2].GetType() != typeof(System.DBNull)) ? (string)row[2] : "";
            empresaObj.Cuit = (string)row[3];
            empresaObj.Usuario = (string)row[4];
            this.loadUsuario(empresaObj, row);
        }
    }
}
