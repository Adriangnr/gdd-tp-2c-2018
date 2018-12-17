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

        private void loadFactura(List<object> row, Factura factura)
        {
            factura.id = (int)row[0];
            factura.fecha = (DateTime)row[1];
            factura.empresa = (int)row[2];
            factura.estado = (int)row[3];
            factura.total = (decimal)row[4];
            factura.totalComision = (decimal)row[5];
        }
    }
}
