using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    public class UbicacionService : DatabaseService
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
            tipoUbicacion.menorFila = (row[2].GetType() != typeof(DBNull)) ? (string)row[2] : null;
            tipoUbicacion.mayorFila = (row[3].GetType() != typeof(DBNull)) ? (string)row[3] : null;
            tipoUbicacion.menorAsiento = (row[4].GetType() != typeof(DBNull)) ? (string)row[4] : null;
            tipoUbicacion.mayorAsiento = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : null;
        }
    }
}
