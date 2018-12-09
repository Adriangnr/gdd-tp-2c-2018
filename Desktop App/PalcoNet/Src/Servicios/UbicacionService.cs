using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Servicios
{
    class UbicacionService : DatabaseService
    {
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
                ubicacion.Id = (int)lista[0];
                ubicacion.Publicacion = (int)lista[1];
                ubicacion.Tipo = (int)lista[2];
                ubicacion.Tipo_descripcion = (string)lista[3];
                ubicacion.Sin_numerar = (bool)lista[4];
                ubicacion.Cant_filas = (int)lista[5];
                ubicacion.Cant_asientos = (int)lista[6];
                ubicacion.Precio = Convert.ToDouble(lista[7]);
                ubicacion.Cant_asientos_opcupados = (int)lista[8];

                ubicaciones.Add(ubicacion);
            });
            return ubicaciones;
        }
    }
}
