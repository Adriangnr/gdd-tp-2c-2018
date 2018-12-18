using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public class ClienteHistorialPaginator : Paginator
    {
        public ClienteHistorialPaginator(Pageable form)
        {
            this.initialize(form);
        }

        public override Page SearchPaged(int offset, int itemsPerPage)
        {
            Page page = new Page();
            List<List<object>> items = null;

            items = this.SearchPagedPublicacionesParaCompra(offset, itemsPerPage);


            EmpresaService empresaService = new EmpresaService();
            GradoService gradoService = new GradoService();
            RubroService rubroService = new RubroService();
            foreach (List<object> row in items)
            {
                Publicacion publicacion = new Publicacion();
                publicacion.Codigo = (int)row[0];
                publicacion.FechaPublicacion = (DateTime)row[1];
                publicacion.Descripcion = (string)row[2];
                publicacion.Rubro = rubroService.GetRubro((int)row[3]);
                publicacion.Direccion = (row[4].GetType() != typeof(DBNull)) ? (string)row[4] : "Indeterminado";
                publicacion.Grado = (row[5].GetType() != typeof(DBNull)) ? gradoService.GetGrado((int)row[5]) : null;
                publicacion.Empresa = empresaService.GetEmpresa((int)row[6]);
                publicacion.Estado = EstadoFactory.getEstado((string)row[7]);
                publicacion.FechaEventoId = (int)row[15];
                publicacion.FechaEvento = (DateTime)row[17];
                page.TotalItems = (int)row[18];
                page.AddItem(publicacion);
            }

            return page;
        }
    }
}
