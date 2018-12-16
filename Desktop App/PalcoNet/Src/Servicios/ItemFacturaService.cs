
using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;

namespace PalcoNet.Src.Servicios
{
    public class ItemFacturaService : DatabaseService
    {
        private DaoItemFactura daoItemFactura = new DaoItemFactura();
        
        public int save(Item_Factura itemFactura)
        {
            try
            {
                return this.daoItemFactura.save(itemFactura);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
