using PalcoNet.Src.Forms.Vistas.Cliente;
using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using PalcoNet.Src.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Src.Forms.Vistas.Paginador
{
    public class CompraPublicacionPaginator : Paginator
    {
        public CompraPublicacionPaginator(Pageable form)
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

        private List<List<object>> SearchPagedPublicacionesParaCompra(int offset, int itemsPerPage)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (KeyValuePair<string, string> filtro in ((Cliente.Compra)this.form).filtros)
            {
                string key = filtro.Key;
                if (key.StartsWith("fecha", false, null))
                {
                    DateTime date = DateTime.Parse(filtro.Value);
                    parameters.Add(new SqlParameter("@" + filtro.Key, date));
                }
                else
                {
                    parameters.Add(new SqlParameter("@" + filtro.Key, filtro.Value));
                }
                
                
            }
            parameters.Add(new SqlParameter("@offset", offset));
            parameters.Add(new SqlParameter("@items", itemsPerPage));
            return new DaoPublicacion().SearchPagedPublicacionesParaCompra(parameters);
        }

    }
}
