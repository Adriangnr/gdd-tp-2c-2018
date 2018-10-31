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

        /*
         * Esta funcion es para ejecutar un sproc que devuelva un escalar
         */
        public int spExecuteScalar(String _spString, List<SqlParameter> _params)
        {
            SqlCommand command = this.dbconnector.obtenerComando();
            command.CommandText = _spString;

            if (_params != null)
                _params.ForEach(
                    param => {
                        command.Parameters.AddWithValue(param.ParameterName, param.Value);
                    });

            var returnParam = command.Parameters.Add("@return_val", SqlDbType.Int);
            returnParam.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            command.Connection.Close();

            return Convert.ToInt32(returnParam.Value);
        }
    }
}
