using PalcoNet.Modelo.DBConector.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Modelo.Entidades
{
    public class DatabaseEntity
    {
        protected Database dbconnector = Database.GetInstance();

        private SqlCommand prepareStoreProcedureCommand(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.dbconnector.obtenerComando();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = _spString;

            if (command.Connection == null) command.Connection = this.dbconnector.ObtenerConexion();

            if (_params != null)
                _params.ForEach(param => command.Parameters.AddWithValue(param.ParameterName, param.Value));

            return command;
        }

        /*
            Devuelve una lista con los datos del registro pedido, para armar el modelo. 
        */
        public List<List<object>> Get(String entityName, List<SqlParameter> _params)
        {
            return this.spExecuteDataReader("ESECUELE.get" + entityName, _params);
        }

        /*
         * Esta funcion es para ejecutar un sproc que devuelva un escalar
         */
        public int spExecuteScalar(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.prepareStoreProcedureCommand(_spString, _params);
            
            var returnParam = command.Parameters.AddWithValue("@return_val", SqlDbType.Int);
            returnParam.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            command.Connection.Close();

            return Convert.ToInt32(returnParam.Value);
        }

        /*Ejecuta un store procedure y devuelve la lista de columnas*/
        public List<List<object>> spExecuteDataReader(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.prepareStoreProcedureCommand(_spString, _params);
            SqlDataReader raws = command.ExecuteReader();
            List<List<object>> results = new List<List<object>>();

            while (raws.Read())
            {
                List<object> raw = new List<object>();
                for (int i = 0; i < raws.FieldCount; i++)
                {
                    raw.Add(raws.GetValue(i));
                }
                results.Add(raw);
            }

            command.Connection.Close();
            return results;
        }


        /*
         * Ejecuta un sproc sin retorno
         */
        public void spExecute(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.prepareStoreProcedureCommand(_spString, _params);

            command.ExecuteNonQuery();

            command.Connection.Close();
        }
    }
}
