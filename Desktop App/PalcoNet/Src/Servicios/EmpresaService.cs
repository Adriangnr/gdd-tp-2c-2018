﻿using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    class EmpresaService : DatabaseService
    {
        DaoEmpresa daoEmpresa = new DaoEmpresa();

        public SortableBindingList<Empresa> Search(System.Windows.Forms.Control.ControlCollection filtros)
        {
            try
            {
                SortableBindingList<Empresa> empresas = new SortableBindingList<Empresa>();

                List<List<object>> results = this.daoEmpresa.Search(filtros);

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

        public void modifyStatus(int empresaId)
        {
            try
            {
                this.daoEmpresa.modifyStatus(empresaId);
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
                    GradoService gradoService = new GradoService();
                    RubroService rubroService = new RubroService();
                    foreach (List<object> row in publicacionesData)
                    {
                        Publicacion publicacion = new Publicacion();
                        publicacion.Codigo = (int)row[0];
                        publicacion.FechaPublicacion = (DateTime)row[1];
                        publicacion.Descripcion = (string)row[2];
                        publicacion.Rubro = rubroService.GetRubro( (int)row[3]);
                        publicacion.Direccion = (row[4].GetType() != typeof(DBNull)) ? (string)row[4] : "";
                        publicacion.Grado = (row[5].GetType() != typeof(DBNull)) ? gradoService.GetGrado((int)row[5]) : null;
                        publicacion.Empresa = this.GetEmpresa( (int)row[6] );
                        publicacion.Estado = EstadoFactory.getEstado( (string)row[7] );
                        PublicacionService publicacionService = new PublicacionService();
                        publicacion.fechas = publicacionService.getFechasDeEvento(publicacion.Codigo);
                        publicacion.ubicaciones = publicacionService.getUbicaciones(publicacion.Codigo);
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

                GradoService gradoService = new GradoService();
                RubroService rubroService = new RubroService();
                Publicacion publicacion = new Publicacion();
                publicacion.Codigo = (int)row[0];
                publicacion.FechaEvento = (DateTime)row[1];
                publicacion.Descripcion = (string)row[2];
                publicacion.FechaEvento = (DateTime)row[3];
                publicacion.Rubro = rubroService.GetRubro( (int)row[4] );
                publicacion.Direccion = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : "Indeterminado";
                publicacion.Grado = (row[6].GetType() != typeof(DBNull)) ? gradoService.GetGrado((int)row[6]) : null;
                publicacion.Empresa = this.GetEmpresa( (int)row[7] );
                publicacion.Estado = EstadoFactory.getEstado((string)row[8]);

                return publicacion;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void update(Empresa empresa)
        {
            try
            {
                daoEmpresa.update(empresa);
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
            empresaObj.Email = (row[13].GetType() != typeof(System.DBNull)) ? (string)row[13] : "";
            this.loadUsuario(empresaObj, row);
        }
    }
}
