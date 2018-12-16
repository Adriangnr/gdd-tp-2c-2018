using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Src.Servicios
{
    class CompraService : DatabaseService
    {
        private string SININFO = "Sin información";

        public SortableBindingList<Publicacion> getAllPublicacionesParaCompra(System.Windows.Forms.Control.ControlCollection filtros)
        {
            PublicacionService publicacionService = (PublicacionService)ServiceFactory.ServiceFactory.GetService("Publicacion");
            try
            {
                SortableBindingList<Publicacion> publicaciones = new SortableBindingList<Publicacion>();
                
                List<List<object>> results = publicacionService.SearchActivasValidas(filtros);

                foreach (List<object> row in results)
                {
                    Publicacion publicacionObj = new Publicacion();
                    this.loadPublicacionCompra(publicacionObj, row);
                    publicaciones.Add(publicacionObj);
                }

                return publicaciones;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void loadPublicacionCompra(Publicacion publicacion, List<object> row)
        {
            publicacion.Codigo = (int)row[0];
            publicacion.FechaPublicacion = (DateTime)row[1];
            publicacion.Descripcion = (string)row[2];
            publicacion.FechaEvento = (DateTime)row[15];
            publicacion.Direccion = (row[4].GetType() != typeof(DBNull))? (string)row[4] : "Indeterminado";

            EmpresaService empresaService = new EmpresaService();

        //    publicacion.Empresa = empresaService.GetEmpresa((int)row[8]);

          //  Console.WriteLine(row.Count);
        }

        public void save(Cliente cliente,List<Entrada> entradas, double montoTotal)
        {
            DatabaseEntity dbEntity = new DatabaseEntity();

            DataTable dt = new DataTable("Nueva_compra");
            dt.Columns.Add("compra_cliente", typeof(int));
            dt.Columns.Add("compra_fecha", typeof(DateTime));
            dt.Columns.Add("compra_monto_total", typeof(double));
            dt.Columns.Add("compra_tarjeta", typeof(string));
            dt.Columns.Add("entrada_ubicacion", typeof(int));
            dt.Columns.Add("entrada_fila", typeof(int));
            dt.Columns.Add("entrada_asiento", typeof(int));

            foreach (Entrada entrada in entradas)
            {
                dt.Rows.Add(cliente.Id,Utilities.getCurrentDate(),montoTotal,cliente.DatosTarjeta,entrada.UbicacionId,entrada.Fila,entrada.Asiento);
            }

            var sqlParam = new SqlParameter("@compra", SqlDbType.Structured);

            sqlParam.Value = dt;
            dbEntity.spExecute("ESECUELE.SaveCompra", new List<SqlParameter> { sqlParam });
        }

        public List<Compra> getAllCompras(Cliente cliente)
        {
            DaoCompra daoCompra = new DaoCompra();

            try
            {
                List<List<Object>> listas = daoCompra.getAllCompras(cliente.Id);

                List<Compra> compras = new List<Compra>();

                foreach (List<object> row in listas)
                {
                    Compra compraObj = new Compra();

                    compraObj.Id = (int)row[0];
                    compraObj.Fecha = (DateTime)row[1];
                    compraObj.MontoTotal = Convert.ToDouble(row[2]);
                    compraObj.Tarjeta = (row[3].GetType() != typeof(DBNull)) ? (string)row[3] : this.SININFO;
                    compraObj.Publicacion = (string)row[4];
                    compraObj.Direccion = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : this.SININFO;
                    compraObj.ClienteNombre = cliente.Nombre;
                    compraObj.ClienteApellido = cliente.Apellido;

                    compras.Add(compraObj);
                }

                return compras;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void getDetallesCompra(Compra compra)
        {
            try
            {
                DaoCompra daoCompra = new DaoCompra();

                List<List<Object>> listas = daoCompra.getCompra(compra.Id);

                this.loadCompra(compra, listas);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void loadCompra(Compra compra, List<List<Object>> listas)
        {
            foreach (List<object> row in listas)
            {
                Entrada_Ticket entrada = new Entrada_Ticket();

                entrada.Id = (int)row[0];
                entrada.SinNumerar = (bool)row[3];

                entrada.Fila = entrada.SinNumerar? ((int)row[1]).ToString(): " ";
                entrada.Asiento = entrada.SinNumerar? ((int)row[2]).ToString(): " ";

                entrada.Precio = Convert.ToDouble(row[4]);
                entrada.Tipo = (string)row[5];

                compra.addEntrada(entrada);
            }

        }
    }
}
