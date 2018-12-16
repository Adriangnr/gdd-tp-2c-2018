using PalcoNet.Src.Modelo.Entidades;
using System;

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
    }
}
