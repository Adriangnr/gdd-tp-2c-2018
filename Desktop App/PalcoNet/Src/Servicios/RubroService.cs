using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Servicios
{
    public class RubroService : DatabaseService
    {
        public List<Rubro> GetRubros()
        {
            List<List<object>> rubros = this.Get("Rubro", new List<SqlParameter>());
            List<Rubro> rubrosList = new List<Rubro>();
            foreach(List<object> row in rubros)
            {
                Rubro rubro = new Rubro((int)row[0], (string)row[1]);
                rubrosList.Add(rubro);
            }
            return rubrosList;
        }
    }
}
