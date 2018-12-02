using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    public class GradoService : DatabaseService
    {
        public List<Grado> GetGrados()
        {
            List<List<object>> grados = this.Get("Grado", new List<SqlParameter>());
            List<Grado> gradosList = new List<Grado>();
            foreach (List<object> row in grados)
            {
                Grado grado = new Grado((int)row[0], (string)row[1], decimal.ToDouble((decimal)row[2]));
                gradosList.Add(grado);
            }
            return gradosList;
        }
    }
}
