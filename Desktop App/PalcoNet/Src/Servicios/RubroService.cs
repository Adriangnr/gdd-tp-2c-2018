using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    class RubroService : DatabaseService
    {
        private DaoRubro daoRubro = new DaoRubro();

        public List<Rubro> getAllRubros()
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            List<List<Object>> listaDeListas = dbEntity.queryListExecute("SELECT * FROM ESECUELE.Rubro ORDER BY rubro_descripcion");
            List<Rubro> rubros = new List<Rubro>();

            listaDeListas.ForEach(lista =>
            {
                rubros.Add(new Rubro(
                    (int)lista[0],
                    (String)lista[1]));
            });

            return rubros;
        }
		
		public Rubro GetRubro(int id)
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            List<List<Object>> lista = dbEntity.queryListExecute(String.Format("SELECT * FROM ESECUELE.Rubro where rubro_codigo = {0}", id));

            Rubro rubro = new Rubro((int)lista[0][0], (string)lista[0][1]);

            return rubro;
		}

        public void save(Rubro rubro)
        {
            try
            {
                this.daoRubro.save(rubro);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Rubro rubro)
        {
            try
            {
                this.daoRubro.delete(rubro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}