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
        public List<Ubicacion> getAllUbicacionesDisponibles(Publicacion publicacion)
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            List<List<Object>> listaDeListas = dbEntity.Get("UbicacionesDisponibles", new List<SqlParameter>
                {
                    new SqlParameter("@publicacion_codigo", publicacion.Codigo)
                });
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            listaDeListas.ForEach(lista =>
            {
                Ubicacion ubicacion = new Ubicacion();


            });
            return ubicaciones;
        }
    }
}
