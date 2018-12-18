using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    public class FacturaService : DatabaseService
    {
        PalcoNet.Src.Modelo.Daos.DaoFactura daoFactura = new PalcoNet.Src.Modelo.Daos.DaoFactura();

        public int save(Factura factura)
        {
            try
            {
                return this.daoFactura.save(factura);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void update(Factura factura)
        {
            try
            {
                this.daoFactura.update(factura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Factura> getFacturasByEmpresa(int empresa){
            try{
                List<Factura> facturas = new List<Factura>();
                List<List<object>> facturasData = this.daoFactura.getFacturasByEmpresa(empresa);

                foreach (List<object>row in facturasData){
                    Factura factura = new Factura();
                    this.loadFactura(row, factura);
                    facturas.Add(factura);
                }

                return facturas;

            }catch(Exception ex){
                throw ex;
            }
        }

        public List<ItemDetail> getItems(int facturaId)
        {
            List<ItemDetail> items = new List<ItemDetail>();
            List<List<object>> data = this.daoFactura.getItems(facturaId);
            foreach(List<object> row in data)
            {
                List<object> details = this.daoFactura.getItemDetail((int)row[0])[0];
                ItemDetail itemDetail = new ItemDetail();
                itemDetail.codCompra = (int)details[0];
                itemDetail.fila = (int)details[1];
                itemDetail.asiento = (int)details[2];
                itemDetail.fechaEvento = (DateTime)details[3];
                itemDetail.publicacion = (int)details[4];
                itemDetail.descripcionUbicacion = (string)details[5];
                itemDetail.monto = (decimal)row[1];
                itemDetail.comision = (decimal)row[2];
                itemDetail.cantidad = (int)row[4];
                itemDetail.entrada = (int)row[5];

                items.Add(itemDetail);
            }

            return items;
        }

        private void loadFactura(List<object> row, Factura factura)
        {
            factura.id = (int)row[0];
            factura.fecha = (DateTime)row[1];
            factura.empresa = (int)row[2];
            factura.estado = ((bool)row[3])?1:0;
            factura.total = (decimal)row[4];
            factura.totalComision = (decimal)row[5];
        }
    }
}
