
using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;

namespace PalcoNet.Src.Servicios
{
    public class ItemFacturaService : DatabaseService
    {
        private DaoItemFactura daoItemFactura = new DaoItemFactura();
        
        public void save(Item_Factura itemFactura)
        {
            try
            {
                this.daoItemFactura.save(itemFactura);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
