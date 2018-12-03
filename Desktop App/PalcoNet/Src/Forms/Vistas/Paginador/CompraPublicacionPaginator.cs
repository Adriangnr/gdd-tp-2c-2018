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
                publicacion.FechaEvento = (DateTime)row[3];
                publicacion.Rubro = rubroService.GetRubro((int)row[4]);
                publicacion.Direccion = (row[5].GetType() != typeof(DBNull)) ? (string)row[5] : "Indeterminado";
                publicacion.Grado = (row[6].GetType() != typeof(DBNull)) ? gradoService.GetGrado((int)row[6]) : null;
                publicacion.Empresa = empresaService.GetEmpresa((int)row[7]);
                publicacion.Estado = EstadoFactory.getEstado((string)row[8]);
                page.TotalItems = (int)row[9];
                page.AddItem(publicacion);
            }

            return page;
        }

        private List<List<object>> SearchPagedPublicacionesParaCompra(int offset, int itemsPerPage)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            foreach (Control field in ((Compra)this.form).Controls)
            {
                if (!field.Name.Contains("Vista"))
                {
                    if (field.GetType() == typeof(TextBox))
                    {
                        string value = null;
                        if (field.Text != "") value = field.Text;
                        parameters.Add(new SqlParameter("@" + field.Name, value));
                    }

                    if (field.GetType() == typeof(DateTimePicker))
                    {
                        parameters.Add(new SqlParameter("@" + field.Name, ((DateTimePicker)field).Value));
                    }
                }
            }
            parameters.Add(new SqlParameter("@offset", offset));
            parameters.Add(new SqlParameter("@items", itemsPerPage));
            return new DaoPublicacion().SearchPagedPublicacionesParaCompra(parameters);
        }

    }
}
