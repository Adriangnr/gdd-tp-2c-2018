using System.Data.SqlClient;
using System.Configuration;
using System;

namespace PalcoNet.Modelo.DBConector.Database
{
    public class Database
    {
        private static Database instance = null;
        private SqlConnection conection = null;

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();

            return instance;
        }

        private SqlConnection ObtenerConexion()
        {
            try
            {
                if(this.conection == null)
                    this.conection = new SqlConnection(ConfigurationManager.ConnectionStrings["GD2C2018ConnectionString"].ToString());
                this.conection.Open();
                return this.conection;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError de conexion: " + e.Message +"\n");
                return null;
            }
        }

        public SqlCommand obtenerComando()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = this.ObtenerConexion();
            return comando;
        }
    }
}
