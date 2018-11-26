using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using PalcoNet.Modelo.DBConector.Database;
using PalcoNet.Src.Modelo.Entidades;

namespace PalcoNet.Src.Servicios
{
    public class DatabaseService
    {
        /*
         Aca van las acciones que sean comunes: Crear, actualizar, borrar, listar, etc.
         Crea un modelo y hace lo que tenga que hacer.
         */
        public List<List<object>> Get(String entityName, List<SqlParameter> _params)
        {
            return new DatabaseEntity().Get(entityName, _params);
        }
    }
}
