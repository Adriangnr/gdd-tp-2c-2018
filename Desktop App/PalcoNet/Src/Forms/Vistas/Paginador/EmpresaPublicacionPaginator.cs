using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Servicios;
using PalcoNet.Src.Servicios.ServiceFactory;
using System.Collections.Generic;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public class EmpresaPublicacionPaginator : Paginator
    {
        public EmpresaPublicacionPaginator(Pageable form)
        {
            this.initialize(form);
        }

        public override Page SearchPaged(int offset, int itemsPerPage)
        {
            Page page = new Page();
            PalcoNet.Src.Modelo.Entidades.Empresa empresa = (PalcoNet.Src.Modelo.Entidades.Empresa)this.Entity;
            List<List<object>> items = null;
            if(empresa == null || empresa.Usuario == "admin")
            {
                items = this.SearchPagedPublicacion(offset, itemsPerPage);
            }
            else
            {
                items = empresa.SearchPagedPublicacionByEmpresa(empresa.Id, offset, itemsPerPage);
            }

            
            foreach(List<object> row in items)
            {
                Publicacion publicacion = new Publicacion();
                PublicacionService publicacionService = (PublicacionService)ServiceFactory.GetService("Publicacion");
                publicacionService.loadPublicacion(publicacion, row);
                page.TotalItems = (int)row[9];
                page.AddItem(publicacion);
            }

            return page;
        }

        private List<List<object>> SearchPagedPublicacion(int offset, int itemsPerPage)
        {
            return new DaoPublicacion().SearchPagedPublicacion(offset, itemsPerPage);
        }
    }
}
