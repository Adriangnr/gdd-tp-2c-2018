

using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace PalcoNet.Src.Servicios
{
    public class PublicacionService : DatabaseService
    {
        private DaoPublicacion daoPublicaion = new DaoPublicacion();

        public List<List<object>> SearchActivasValidas(Control.ControlCollection filtros)
        {
            return this.daoPublicaion.SearchActivasValidas(filtros);
        }

        public List<FechaHora> getFechasDeEvento(int codigo)
        {
            List<FechaHora> fechas = new List<FechaHora>();
            List<List<object>> rows = daoPublicaion.getFechas(codigo);
            foreach(List<object> row in rows){
                FechaHora fechaHora = new FechaHora((DateTime)row[1]);
                fechaHora.setCodigoPublicacion((int)row[0]);
                fechas.Add(fechaHora);
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
            ubicacion.id = (int)row[0];
            ubicacion.tipo = (int)row[1];
            ubicacion.descripcion = (string)row[2];
            ubicacion.filas = (int)row[3];
            ubicacion.asientos = (int)row[4];
            ubicacion.precio = Convert.ToDouble(row[5].ToString());
            ubicacion.sinNumerar = (bool)row[6];
            ubicacion.ocupados = (int)row[7];
            ubicacion.cantSinNumerar = (((int)row[1]) == 4454) ? (int)row[4] : 0;
        }

        public void loadPublicacion(Publicacion publicacion, List<object> row)
        {
            EmpresaService empresaService = new EmpresaService();
            GradoService gradoService = new GradoService();
            RubroService rubroService = new RubroService();

            publicacion.Codigo = (int)row[0];
            publicacion.FechaPublicacion = (DateTime)row[1];
            publicacion.Descripcion = (string)row[2];
            publicacion.FechaEvento = (DateTime)row[3];
            publicacion.Rubro = rubroService.GetRubro((int)row[4]);
            publicacion.Direccion = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : "Indeterminado";

            if (row[6].GetType() != typeof(DBNull))
            {
                publicacion.Grado = gradoService.GetGrado((int)row[6]);
            }
            else
            {
                Grado gradoIndef = new Grado();
                gradoIndef.comision = 0;
                gradoIndef.descripcion = "Indefinido";
                gradoIndef.id = -1;
                publicacion.Grado = gradoIndef;
            }
            publicacion.Empresa = empresaService.GetEmpresa((int)row[7]);
            publicacion.Estado = EstadoFactory.getEstado((string)row[8]);
            publicacion.fechas = this.getFechasDeEvento(publicacion.Codigo);
            publicacion.ubicaciones = this.getUbicaciones(publicacion.Codigo);
        }

        public void save(Publicacion newPublicacion, List<DateTime> fechas, List<Dictionary<string, object>> ubicaciones)
        {
            foreach(DateTime fecha in fechas)
            {
                newPublicacion.FechaEvento = fecha;
                newPublicacion.Codigo = this.daoPublicaion.save(newPublicacion);
                this.saveUbicaciones(newPublicacion, ubicaciones);
            }
        }

        public int update(Publicacion newPublicacion, List<DateTime> fechas, List<Dictionary<string, object>> ubicaciones)
        {
            foreach (DateTime fecha in fechas)
            {
                newPublicacion.FechaEvento = fecha;
                newPublicacion.Codigo = this.daoPublicaion.save(newPublicacion);
                this.saveUbicaciones(newPublicacion, ubicaciones);
            }
            return this.daoPublicaion.save(newPublicacion);
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

                    ubicacion.descripcion = ((Tipo_Ubicacion)ubicacionData["descripcion"]).descripcion;
                    ubicacion.tipo = ((Tipo_Ubicacion)ubicacionData["descripcion"]).id;
                    ubicacion.filas = ((string)ubicacionData["fila"] != "") ? Convert.ToInt16((string)ubicacionData["fila"]) : 0;
                    ubicacion.asientos = ((string)ubicacionData["asiento"] != "") ? Convert.ToInt16((string)ubicacionData["asiento"]) : 0;
                    ubicacion.precio = (double)ubicacionData["precio"];
                    ubicacion.cantSinNumerar = Convert.ToInt16((short)ubicacionData["cantidad"]);
                    ubicacion.sinNumerar = false;
                    if (ubicacion.descripcion == "Sin Numerar") ubicacion.sinNumerar = true;
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
