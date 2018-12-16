

using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    public class ComisionesService : DatabaseService
    {
        private CompraService compraService = new CompraService();
        private PublicacionService publicacionService = new PublicacionService();
        private DaoCompra daoCompra = new DaoCompra();

        public void comisionar(int cantidad, int empresa)
        {
            /*
             me traigo las n compras de la empresa. 
             recorro la lista. 
             me traigo la publicacion para saber el grado. 
             calculo la comision.
             armo la factura con el total y desc de la empresa.
             cargo los items_factura (compras)
             */
            List<Compra> compras = this.getComprasComision(cantidad, empresa);
            foreach(Compra compra in compras)
            {
                Publicacion publicacion = this.publicacionService.getPublicacion(compra.publicacion);
            }
        }

        private List<Compra> getComprasComision(int cantidad, int empresaId)
        {
            List<Compra> compras = new List<Compra>();
            List<List<object>> comprasData = daoCompra.getComprasComision(cantidad, empresaId);
            foreach (List<object> row in comprasData)
            {
                Compra compra = this.compraService.getCompra((int)row[1]);
            }
            return compras;
        }
    }
}
