using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    class EmpresaService : DatabaseService
    {
        public SortableBindingList<Empresa> Search(System.Windows.Forms.Control.ControlCollection filtros)
        {
            Empresa empresaSearchEntity = new Empresa();
            try
            {
                SortableBindingList<Empresa> empresas = new SortableBindingList<Empresa>();

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
            List<object> empresaData = this.Get("Empresa", new List<SqlParameter> { new SqlParameter("@id", id) })[0];

            Empresa empresa = new Empresa();

            this.loadEmpresa(empresa, empresaData);

            return empresa;
        }

        public Empresa GetEmpresaFromUsername(string username)
        {
            try
            {
                List<object> empresaData = this.Get("EmpresaFromUsername", new List<SqlParameter> { new SqlParameter("@username", username) })[0];
                Empresa empresa = new Empresa();
                this.loadEmpresa(empresa, empresaData);

                return empresa;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public List<Publicacion> GetPublicaciones(string username)
        {
            try
            {
                Empresa empresaEntity = this.GetEmpresaFromUsername(username);
                List<Publicacion> publicaciones = new List<Publicacion>();
                if(empresaEntity != null)
                {
                    List<List<object>> publicacionesData = empresaEntity.GetPublicaciones();

                    foreach (List<object> row in publicacionesData)
                    {
                        Publicacion publicacion = new Publicacion();
                        publicacion.Codigo = (int)row[0];
                        publicacion.FechaInicio = (DateTime)row[1];
                        publicacion.Descripcion = (string)row[2];
                        publicacion.FechaEvento = (DateTime)row[3];
                        publicacion.Rubro = (int)row[4];
                        publicacion.Direccion = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : "";
                        publicacion.Grado = (row[6].GetType() != typeof(DBNull)) ? (int)row[6] : -1;
                        publicacion.Empresa = (int)row[7];
                        publicacion.Estado = (string)row[8];

                        publicaciones.Add(publicacion);
                    }
                }
                return publicaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Publicacion GetPublicacion(string username, int idPublicacion)
        {
            try
            {
                Empresa empresaEntity = this.GetEmpresaFromUsername(username);
                List<object> row = empresaEntity.GetPublicacion(idPublicacion)[0];

                Publicacion publicacion = new Publicacion();
                publicacion.Codigo = (int)row[0];
                publicacion.FechaInicio = (DateTime)row[1];
                publicacion.Descripcion = (string)row[2];
                publicacion.FechaEvento = (DateTime)row[3];
                publicacion.Rubro = (int)row[4];
                publicacion.Direccion = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : "";
                publicacion.Grado = (row[6].GetType() != typeof(DBNull)) ? (int)row[6] : -1;
                publicacion.Empresa = (int)row[7];
                publicacion.Estado = (string)row[8];

                return publicacion;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void borrar(int id)
        {
            try
            {
                Empresa empresaObj = new Empresa();
                empresaObj.borrar(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void loadEmpresa(Empresa empresaObj, List<object> row)
        {
            empresaObj.Id = (int)row[0];
            empresaObj.RazonSocial = (string)row[1];
            empresaObj.Ciudad = (row[2].GetType() != typeof(System.DBNull)) ? (string)row[2] : "";
            empresaObj.Cuit = (string)row[3];
            empresaObj.Usuario = (string)row[4];
            empresaObj.Email = (string)row[13];
            this.loadUsuario(empresaObj, row);
        }
    }
}
