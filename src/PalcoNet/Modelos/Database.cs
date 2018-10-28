using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace PalcoNet.Modelos
{
    static class Database
    {
        private static SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["GD2C2018ConnectionString"]
          .ConnectionString);

        public static SqlCommand sp_crear(String _storeProcedure)
        {
            var command = new SqlCommand
            {
                CommandText = _storeProcedure,
                CommandType = CommandType.StoredProcedure
            };

            command.Connection = conexion;

            return command;
        }

        /*
         * Esta funcion es para ejecutar un sproc que devuelva un escalar
         */
        public static int spExecuteScalar(String _spString, List<SqlParameter> _params)
        {
            var _sp = sp_crear(_spString);

            conexion.Open();

            if (_params != null)
                _params.ForEach(param => _sp.Parameters.Add(param));

            var returnParam = _sp.Parameters.Add("@return_val", SqlDbType.Int);
            returnParam.Direction = ParameterDirection.Output;

            _sp.ExecuteNonQuery();

            conexion.Close();
            return Convert.ToInt32(returnParam.Value);
        }
    }
}
