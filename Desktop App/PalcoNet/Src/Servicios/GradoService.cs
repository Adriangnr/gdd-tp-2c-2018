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
            List<List<object>> grados = this.Get("AllGradoHabilitado", new List<SqlParameter>());
            List<Grado> gradosList = new List<Grado>();
            foreach (List<object> row in grados)
            {
                Grado grado = new Grado((int)row[0], (string)row[1], Convert.ToDecimal(row[2]));
                grado.habilitado = true;
                gradosList.Add(grado);
            }
            return gradosList;
        }

        public Grado GetGrado(int id)
        {
            List<object> data = this.Get("Grado", new List<SqlParameter> { new SqlParameter("@id", id) })[0];

            Grado grado = new Grado();

            this.loadGrado(grado, data);

            return grado;
        }

        public void save(string descripcion, decimal comision)
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
            grado.comision = (decimal)row[2];
        }

        public List<Grado> GetAllGrados()
        {
            DatabaseEntity db = new DatabaseEntity();

            List<List<object>> grados = db.queryListExecute("SELECT * FROM ESECUELE.GRADO");
            List<Grado> gradosList = new List<Grado>();
            foreach (List<object> row in grados)
            {
                Grado grado = new Grado((int)row[0], (string)row[1], Convert.ToDecimal(row[2]));
                grado.habilitado = (bool)row[3];
                gradosList.Add(grado);
            }
            return gradosList;
        }

        public void habilitar(Grado grado)
        {
            try
            {
                this.daoGrado.habilitar(grado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
