

using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Servicios
{
    public class PublicacionService : DatabaseService
    {
        private DaoPublicacion daoPublicaion = new DaoPublicacion();

        public List<List<object>> SearchActivasValidas(Control.ControlCollection filtros)
        {
            return this.daoPublicaion.SearchActivasValidas(filtros);
        }

        public List<DateTime> getFechasDeEvento(int codigo)
        {
            List<DateTime> fechas = new List<DateTime>();
            List<List<object>> rows = daoPublicaion.getFechas(codigo);
            foreach(List<object> row in rows){
                fechas.Add((DateTime)row[0]);
            }
            return fechas;
        }

        public List<Ubicacion> getUbicaciones(int codigo)
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            List<List<object>> rows = daoPublicaion.getUbicacionesDisponibles(codigo);
            foreach (List<object> row in rows)
            {
                Ubicacion ubicacion = new Ubicacion();
                this.loadUbicacion(ubicacion, row);
                ubicaciones.Add(ubicacion);
            }
            return ubicaciones;
        }

        public void loadUbicacion(Ubicacion ubicacion, List<object> row)
        {
            Tipo_Ubicacion tipo = new Tipo_Ubicacion((int)row[1], (string)row[2]);

            ubicacion.id = (int)row[0];
            ubicacion.tipo = tipo;
            ubicacion.filas = (int)row[3];
            ubicacion.asientos = (int)row[4];
            ubicacion.precio = Convert.ToDouble(row[5].ToString());
            ubicacion.sinNumerar = (bool)row[6];
            ubicacion.ocupados = (int)row[7];

            if (ubicacion.sinNumerar)
                ubicacion.cantSinNumerar = (int)row[4];
            else
            {
                ubicacion.filas = (int)row[3];
                ubicacion.asientos = (int)row[4];
            }
        }

        public void loadPublicacion(Publicacion publicacion, List<object> row)
        {
            EmpresaService empresaService = new EmpresaService();
            GradoService gradoService = new GradoService();
            RubroService rubroService = new RubroService();

            publicacion.Codigo = (int)row[0];
            publicacion.FechaPublicacion = (DateTime)row[1];
            publicacion.Descripcion = (string)row[2];
            publicacion.Rubro = rubroService.GetRubro((int)row[3]);
            publicacion.Direccion = (row[4].GetType() != typeof(DBNull)) ? (string)row[4] : "Indeterminado";

            if (row[5].GetType() != typeof(DBNull))
            {
                publicacion.Grado = gradoService.GetGrado((int)row[5]);
            }
            else
            {
                Grado gradoIndef = new Grado();
                gradoIndef.comision = 0;
                gradoIndef.descripcion = "Indefinido";
                gradoIndef.id = -1;
                publicacion.Grado = gradoIndef;
            }
            publicacion.Empresa = empresaService.GetEmpresa((int)row[6]);
            publicacion.Estado = EstadoFactory.getEstado((string)row[7]);
            publicacion.fechas = this.getFechasDeEvento(publicacion.Codigo);
            publicacion.ubicaciones = this.getUbicaciones(publicacion.Codigo);
        }

        public void save(Publicacion newPublicacion, List<DateTime> fechas, List<Dictionary<string, object>> ubicaciones)
        {
            newPublicacion.Codigo = this.daoPublicaion.save(newPublicacion);
            this.daoPublicaion.saveDates(newPublicacion.Codigo, fechas);
            this.saveUbicaciones(newPublicacion, ubicaciones);
        }

        public int update(Publicacion publicacion, List<DateTime> fechas, List<Dictionary<string, object>> ubicaciones)
        {
            if(ubicaciones != null)
            {
                this.daoPublicaion.deleteUbicaciones(publicacion.Codigo);
                this.saveUbicaciones(publicacion, ubicaciones);
            }
            
            if(fechas != null)
            {
                this.daoPublicaion.deleteFechas(publicacion.Codigo);
                this.daoPublicaion.saveDates(publicacion.Codigo, fechas);
            }
            
            return this.daoPublicaion.update(publicacion);
        }

        public Publicacion loadData(Dictionary<string, object> data)
        {
            Publicacion newPublicacion = new Publicacion();

            newPublicacion.Descripcion = (string)data["Descripcion"];
            newPublicacion.Direccion = (string)data["Direccion"];
            newPublicacion.setEmpresaId((int)data["EmpresaId"]);
            newPublicacion.Estado = (Estado)data["Estado"];
            newPublicacion.Rubro = (Rubro)data["Rubro"];
            newPublicacion.Grado = (Grado)data["Grado"];
            newPublicacion.FechaPublicacion = (DateTime)data["FechaPublicacion"];

            return newPublicacion;
        }

        private void saveUbicaciones(Publicacion newPublicacion, List<Dictionary<string, object>> ubicaciones)
        {
            try
            {
                foreach (Dictionary<string, object> ubicacionData in ubicaciones)
                {
                    Ubicacion ubicacion = new Ubicacion();
                    ubicacion.publicacion = newPublicacion.Codigo;

                    Tipo_Ubicacion tipo = new Tipo_Ubicacion(((Tipo_Ubicacion)ubicacionData["descripcion"]).id,((Tipo_Ubicacion)ubicacionData["descripcion"]).descripcion);
                    
                    ubicacion.tipo = tipo;

                    ubicacion.filas = Convert.ToInt16(ubicacionData["fila"]);

                    ubicacion.asientos = Convert.ToInt16(ubicacionData["asiento"]);
                    ubicacion.precio = (double)ubicacionData["precio"];
                    ubicacion.cantSinNumerar = Convert.ToInt16(ubicacionData["cantidad"]);
                    ubicacion.sinNumerar = (bool)ubicacionData["sinNumerar"];
                    ubicacion.ocupados = 0;

                    this.daoPublicaion.saveUbicacion(ubicacion);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }
    }
}
