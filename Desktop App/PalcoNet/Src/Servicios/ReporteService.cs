using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Servicios
{
    public class ReporteService: DatabaseService
    {
        public List<Reporte1> obtenerReporte1(int anio, int trimestre, Grado grado)
        {
            DatabaseEntity db = new DatabaseEntity();

            List<List<Object>> listaDeListas = db.spExecuteDataReader("ESECUELE.ReporteUno", new List<System.Data.SqlClient.SqlParameter> { });

            List<Reporte1> reporte = new List<Reporte1>();

            foreach (List<object> row in listaDeListas)
            {
                Reporte1 repo = new Reporte1();
                this.loadReporte1(repo, row);
                reporte.Add(repo);
            }

            return reporte;
        }

        public List<Reporte2> obtenerReporte2(int anio, int trimestre)
        {
            DatabaseEntity db = new DatabaseEntity();
            List<List<Object>> listaDeListas = db.spExecuteDataReader("ESECUELE.ReporteDos", new List<System.Data.SqlClient.SqlParameter> { });

            List<Reporte2> reporte = new List<Reporte2>();
            foreach (List<object> row in listaDeListas)
            {
                Reporte2 repo = new Reporte2();
                this.loadReporte2(repo, row);
                reporte.Add(repo);
            }
            return reporte;
        }

        public List<Reporte3> obtenerReporte3(int anio, int trimestre)
        {
            DatabaseEntity db = new DatabaseEntity();
            List<List<Object>> listaDeListas = db.spExecuteDataReader("ESECUELE.ReporteTres", new List<System.Data.SqlClient.SqlParameter> { });

            List<Reporte3> reporte = new List<Reporte3>();
            foreach (List<object> row in listaDeListas)
            {
                Reporte3 repo = new Reporte3();
                this.loadReporte3(repo, row);
                reporte.Add(repo);
            }
            return reporte;
        }

        private void loadReporte1(Reporte1 repo, List<object> row)
        {
            throw new NotImplementedException();
        }

        private void loadReporte2(Reporte2 repo, List<object> row)
        {
            throw new NotImplementedException();
        }

        private void loadReporte3(Reporte3 repo, List<object> row)
        {
            throw new NotImplementedException();
        }
    }
}
