using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Servicios
{
    public class ProductoService: DatabaseService
    {
        public List<Producto> getAllProducto()
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            List<List<Object>> listaDeListas = dbEntity.queryListExecute("SELECT * FROM ESECUELE.Producto");
            List<Producto> productos = new List<Producto>();
            listaDeListas.ForEach(row =>
            {
                Producto prod = new Producto();

                prod.Id = (int)row[0];
                prod.Descripcion = (string)row[1];
                prod.Valor = (int)row[2];

                productos.Add(prod);
            });
            return productos;
        }

        public void canjearProducto(int clienteId, int productoId, int productoValor)
        {
            try
            {
                DatabaseEntity dbEntity = new DatabaseEntity();

                dbEntity.spExecute("ESECUELE.CanjearProducto", new List<SqlParameter>() {
                    new SqlParameter("@cliente", clienteId),
                    new SqlParameter("@producto", productoId),
                    new SqlParameter("@valor", productoValor),
                    new SqlParameter("@fecha", Utils.Utilities.getCurrentDate())
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Canje> getHistorialCanje(Cliente cliente)
        {
            DatabaseEntity dbEntity = new DatabaseEntity();
            List<List<Object>> listaDeListas = dbEntity.spExecuteDataReader("ESECUELE.CanjeHistorial", new List<SqlParameter> { 
                new SqlParameter("@cliente", cliente.Id)
            });
            List<Canje> canjes = new List<Canje>();
            listaDeListas.ForEach(row =>
            {
                Canje canje = new Canje();

                canje.Id = (int)row[0];
                canje.Fecha = (DateTime)row[1];
                canje.Producto = (string)row[2];

                canjes.Add(canje);
            });
            return canjes;
        }
    }
}
