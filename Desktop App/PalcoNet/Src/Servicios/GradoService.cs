using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    public class GradoService : DatabaseService
    {
        private DaoGrado daoGrado = new DaoGrado();

        public List<Grado> GetGrados()
        {
            List<List<object>> grados = this.Get("AllGrado", new List<SqlParameter>());
            List<Grado> gradosList = new List<Grado>();
            foreach (List<object> row in grados)
            {
                Grado grado = new Grado((int)row[0], (string)row[1], Convert.ToDouble(row[2]));
                gradosList.Add(grado);
            }
            //Grado gradoIndef = new Grado(-1, "Indefinido", 0);
           // gradosList.Add(gradoIndef);
            return gradosList;
        }

        public Grado GetGrado(int id)
        {
            List<object> data = this.Get("Grado", new List<SqlParameter> { new SqlParameter("@id", id) })[0];

            Grado grado = new Grado();

            this.loadGrado(grado, data);

            return grado;
        }

        public void save(string descripcion, double comision)
        {
            try
            {
                Grado grado = new Grado(descripcion, comision);
                this.daoGrado.save(grado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(Grado grado)
        {
            try
            {
                this.daoGrado.update(grado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Grado grado)
        {
            try
            {
                this.daoGrado.delete(grado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void loadGrado(Grado grado, List<object> row)
        {
            grado.id = (int)row[0];
            grado.descripcion = (string)row[1];
            grado.comision = Convert.ToDouble((string)row[2]);
        }
    }
}
