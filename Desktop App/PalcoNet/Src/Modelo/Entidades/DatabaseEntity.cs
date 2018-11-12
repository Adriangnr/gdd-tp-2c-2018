using PalcoNet.Modelo.DBConector.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Src.Modelo.Entidades
{
    public class DatabaseEntity
    {
        protected string schema = "ESECUELE";
        protected Database dbconnector = Database.GetInstance();

        public List<List<object>> queryListExecute(String _query)
        {
            List<List<object>> results = null;
            SqlCommand command = this.dbconnector.obtenerComando();
            command.CommandType = CommandType.Text;
            command.CommandText = _query;

            try
            {
                SqlDataReader raws = command.ExecuteReader();
                results = llenarLista(raws);
            }
            finally
            {
                command.Connection.Close();
            }

            return results;
        }

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
            return this.spExecuteDataReader(this.schema+".get" + entityName, _params);
        }

        /*
         * Esta funcion es para ejecutar un sproc que devuelva un escalar
         */
        public int spExecuteScalar(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.prepareStoreProcedureCommand(_spString, _params);
            
            var returnParam = command.Parameters.AddWithValue("@return_val", SqlDbType.Int);
            returnParam.Direction = ParameterDirection.Output;

            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                command.Connection.Close();
            }

            return Convert.ToInt32(returnParam.Value);
        }

        /*
         * Para usar por si devuelve un error desde la base
         * Sacar si no es necesario
         */
        public Boolean listadoVacio(List<List<object>> lista)
        {
            if (lista == null)
                return true;
            else
                return lista.Count == 0;
        }

        private List<List<object>> llenarLista(SqlDataReader raws)
        {
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
            return results;
        }

        /*Ejecuta un store procedure y devuelve la lista de columnas*/
        public List<List<object>> spExecuteDataReader(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.prepareStoreProcedureCommand(_spString, _params);
            List<List<object>> results = null;

            try
            {
                SqlDataReader raws = command.ExecuteReader();

                results = llenarLista(raws);
            }
            finally
            {
                command.Connection.Close();
            }
            return results;
        }


        /*
         * Ejecuta un sproc sin retorno
         */
        public void spExecute(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.prepareStoreProcedureCommand(_spString, _params);
            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
