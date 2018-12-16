

using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Servicios
{
    public class ComisionesService : DatabaseService
    {
        private CompraService compraService = new CompraService();
        private PublicacionService publicacionService = new PublicacionService();
        private FacturaService facturaService = new FacturaService();
        private EntradaService entradaService = new EntradaService();
        private ItemFacturaService itemFacturaService = new ItemFacturaService();

        private DaoCompra daoCompra = new DaoCompra();

        public void comisionar(int cantidad, int empresa)
        {
            /*
             *me traigo las n compras de la empresa. 
             *recorro la lista. 
             *me traigo la publicacion para saber el grado. 
             calculo la comision.
             armo la factura con el total y desc de la empresa.
             cargo los items_factura (compras)
             */
            try
            {
                List<Compra> compras = this.getComprasComision(cantidad, empresa);
                foreach (Compra compra in compras)
                {
                    Factura factura = new Factura();
                    factura.fecha = Utils.Utilities.getCurrentDate();
                    factura.empresa = compras[0].publicacion.Empresa.Id;
                    factura.estado = 1;
                    factura.formaPago = "Efectivo";
                    factura.id = this.facturaService.save(factura);

                    decimal total = 0;
                    decimal totalComision = 0;

                    foreach (Entrada entrada in compra.entradas)
                    {
                        Item_Factura itemFactura = new Item_Factura();
                        itemFactura.facturaId = factura.id;
                        itemFactura.monto = (decimal)entrada.Precio;
                        total += itemFactura.monto;
                        itemFactura.descripcion = "Comisiones por compras.";
                        itemFactura.cantidad = 1;
                        itemFactura.entrada = entrada.Id;
                        itemFactura.comision = (itemFactura.monto) * ((decimal)compra.publicacion.Grado.comision);
                        this.itemFacturaService.save(itemFactura);
                        totalComision += itemFactura.comision;
                    }
                    factura.total = total;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Compra> getComprasComision(int cantidad, int empresaId)
        {
            List<Compra> compras = new List<Compra>();
            List<List<object>> comprasData = daoCompra.getComprasComision(cantidad, empresaId);
            foreach (List<object> row in comprasData)
            {
                Compra compra = this.compraService.getCompra((int)row[1]);
                compra.publicacion = this.publicacionService.getPublicacion((int)row[0]);
                compra.entradas = this.entradaService.getEntradasByCompra(compra.id);
                compras.Add(compra);
            }
            return compras;
        }
    }
}
