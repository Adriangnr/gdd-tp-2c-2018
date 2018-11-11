using System;
using System.Collections.Generic;
using PalcoNet.Src.Modelo.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    class RolService : DatabaseService
    {
        public List<Funcionalidad> getAllFuncionalidades()
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            List<List<Object>> listaDeListas = dbEntity.Get("FullListFuncionalidad", null);
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            listaDeListas.ForEach( lista => {
                funcionalidades.Add(new Funcionalidad(
                    (byte)lista[0],
                    (String)lista[1],
                    (String)lista[2]));
            });
            return funcionalidades;
        }

        public void saveRol(Rol rol)
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            int rol_nuevo_id = dbEntity.spExecuteScalar("ESECUELE.SaveRol", new List<SqlParameter>
                {
                        new SqlParameter("@rol_nombre_nuevo", rol.Nombre)
                });

            DataTable dt = new DataTable("Nuevo_rol");
            dt.Columns.Add("frol_rol_id", typeof(int));
            dt.Columns.Add("frol_func_id", typeof(int));

            foreach (Funcionalidad funcionalidad in rol.GetFuncionalidades())
            {
                dt.Rows.Add(rol_nuevo_id, funcionalidad.GetId());
            }

            var sqlParam = new SqlParameter("@func_nuevo_rol", SqlDbType.Structured);

            sqlParam.Value = dt;
            dbEntity.spExecute("ESECUELE.SaveRolFuncionalidades", new List<SqlParameter> {  sqlParam });

        }
    }
}
