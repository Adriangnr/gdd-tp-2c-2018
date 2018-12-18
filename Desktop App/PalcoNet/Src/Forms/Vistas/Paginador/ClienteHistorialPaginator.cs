using PalcoNet.Src.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public class ClienteHistorialPaginator : Paginator
    {
        CompraService compraService = new CompraService();

        public ClienteHistorialPaginator(Pageable form)
        {
            this.initialize(form);
        }

        public override Page SearchPaged(int offset, int itemsPerPage)
        {
            Page page = new Page();
            List<PalcoNet.Src.Modelo.Entidades.Compra_Ticket> items = compraService.getAllCompras((PalcoNet.Src.Modelo.Entidades.Cliente)this.Entity, offset, itemsPerPage);
            page.TotalItems = items[0].cantidadTotalPaginador;

            foreach (PalcoNet.Src.Modelo.Entidades.Compra_Ticket compraTicket in items)
            {
                page.AddItem(compraTicket);
            }

            return page;
        }
    }
}
