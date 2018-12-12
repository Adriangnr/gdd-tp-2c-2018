using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    class UbicacionService : DatabaseService
    {
    private DaoTipoUbicacion datoTipoUbicacion = new DaoTipoUbicacion();

        public List<Tipo_Ubicacion> getTiposUbicaciones()
        {
            List<List<object>> rows = this.datoTipoUbicacion.getTiposUbicaciones();
            List<Tipo_Ubicacion> tiposUbicaciones = new List<Tipo_Ubicacion>();

            foreach(List<object> row in rows)
            {
                Tipo_Ubicacion tipoUbicacion = new Tipo_Ubicacion();
                this.loadTipoUbicacion(tipoUbicacion, row);
                tiposUbicaciones.Add(tipoUbicacion);
            }

            return tiposUbicaciones;
        }

        public void loadTipoUbicacion(Tipo_Ubicacion tipoUbicacion, List<object> row)
        {
            tipoUbicacion.id = (int)row[0];
            tipoUbicacion.descripcion = (string)row[1];
        }
    
        public List<Ubicacion> getAllUbicacionesDisponibles(int publicacion)
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            List<List<Object>> listaDeListas = dbEntity.Get("Ubicaciones", new List<SqlParameter>
                {
                    new SqlParameter("@publicacion_codigo", publicacion)
                });
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            listaDeListas.ForEach(lista =>
            {
                Ubicacion ubicacion = new Ubicacion();
                ubicacion.id= (int)lista[0];
                ubicacion.publicacion = (int)lista[1];

                Tipo_Ubicacion tipo = new Tipo_Ubicacion((int)lista[2], (string)lista[3]);

                ubicacion.tipo = tipo;
                ubicacion.sinNumerar = (bool)lista[4];
                ubicacion.filas = (int)lista[5];
                ubicacion.asientos = (int)lista[6];
                ubicacion.precio = Convert.ToDouble(lista[7]);
                ubicacion.ocupados = (int)lista[8];

                ubicaciones.Add(ubicacion);
            });
            return ubicaciones;
        }
    }
}
