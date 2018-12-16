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
        DaoCompra daoCompra = new DaoCompra();
        EntradaService entradaService = new EntradaService();

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

        public int getCountComprasOfEmpresa(int id)
        {
            try
            {
                return this.daoCompra.getCountComprasOfEmpresa(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Compra getCompra(int id)
        {
            try
            {
                List<object> compraData = this.daoCompra.getCompra(id)[0];
                Compra compra = new Compra();
                compra.id = (int)compraData[0];
                compra.fecha = (DateTime)compraData[3];
                compra.clienteId = (int)compraData[2];
                compra.total = (decimal)compraData[1];
                compra.medioDePago = (compraData[4].GetType() == typeof(System.DBNull)) ? (int)compraData[4] : -1;
                compra.entradas = entradaService.getEntradasByCompra(compra.id);
                return compra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
