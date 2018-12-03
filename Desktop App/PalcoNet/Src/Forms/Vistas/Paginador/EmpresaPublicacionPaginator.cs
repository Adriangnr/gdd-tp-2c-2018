using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using PalcoNet.Src.Servicios;
using System;
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
            if(empresa == null)
            {
                items = this.SearchPagedPublicacion(offset, itemsPerPage);
            }
            else
            {
                items = empresa.SearchPagedPublicacionByEmpresa(empresa.Id, offset, itemsPerPage);
            }

            EmpresaService empresaService = new EmpresaService();
            GradoService gradoService = new GradoService();
            RubroService rubroService = new RubroService();
            foreach(List<object> row in items)
            {
                Publicacion publicacion = new Publicacion();
                publicacion.Codigo = (int)row[0];
                publicacion.FechaPublicacion = (DateTime)row[1];
                publicacion.Descripcion = (string)row[2];
                publicacion.FechaEvento = (DateTime)row[3];
                publicacion.Rubro = rubroService.GetRubro( (int)row[4] );
                publicacion.Direccion = (row[5].GetType() != typeof(DBNull)) ?  (string)row[5]: "Indeterminado";
                publicacion.Grado = (row[6].GetType() != typeof(DBNull)) ? gradoService.GetGrado((int)row[6]) : null;
                publicacion.Empresa = empresaService.GetEmpresa( (int)row[7]);
                publicacion.Estado = EstadoFactory.getEstado((string)row[8]);
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
