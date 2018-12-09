

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
            ubicacion.tipo = (int)row[0];
            ubicacion.descripcion = (string)row[1];
            ubicacion.fila = (string)row[2];
            ubicacion.asiento = (string)row[3];
            ubicacion.precio = Convert.ToDouble(row[4].ToString()); ;
            ubicacion.cantidad = (int)row[5];
            ubicacion.disponible = (int)row[6];
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

        public int save(Publicacion newPublicacion)
        {
            return this.daoPublicaion.save(newPublicacion);
        }

        public Publicacion loadData(Dictionary<string, object> data)
        {
            Publicacion newPublicacion = new Publicacion();

            return newPublicacion;
        }
    }
}
