using PalcoNet.Src.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public class EmpresaPublicacionPaginator : Paginator
    {
        public override Page SearchPaged(int offset, int itemsPerPage)
        {
            Page page = new Page();
            PalcoNet.Src.Modelo.Entidades.Empresa empresa = (PalcoNet.Src.Modelo.Entidades.Empresa)this.Entity;
            List<List<object>> items = null;
            if(empresa == null)
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
                publicacion.Codigo = (int)row[0];
                publicacion.FechaPublicacion = (DateTime)row[1];
                publicacion.Descripcion = (string)row[2];
                publicacion.FechaEvento = (DateTime)row[3];
                publicacion.Rubro = (int)row[4];
                publicacion.Direccion = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : "";
                publicacion.Grado = (row[6].GetType() != typeof(DBNull)) ? (int)row[6] : -1;
                publicacion.Empresa = (int)row[7];
                publicacion.Estado = (string)row[8];
                page.TotalItems = (int)row[9];
                page.AddItem(publicacion);
            }

            return page;
        }

        private List<List<object>> SearchPagedPublicacion(int offset, int itemsPerPage)
        {
            return new Publicacion().SearchPagedPublicacion(offset, itemsPerPage);
        }
    }
}
