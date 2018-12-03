using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Servicios
{
    class CompraService : DatabaseService
    {
        public SortableBindingList<Publicacion> getAllPublicacionesParaCompra(System.Windows.Forms.Control.ControlCollection filtros)
        {
            Publicacion publicacionSearchEntity = new Publicacion();
            try
            {
                SortableBindingList<Publicacion> publicaciones = new SortableBindingList<Publicacion>();

                List<List<object>> results = publicacionSearchEntity.SearchActivasValidas(filtros);

                foreach (List<object> row in results)
                {
                    Publicacion clienteObj = new Publicacion();
                    this.loadPublicacionCompra(clienteObj, row);
                    publicaciones.Add(clienteObj);
                }

                return publicaciones;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void loadPublicacionCompra(Publicacion publicacion, List<object> row)
        {
            publicacion.Codigo = (int)row[0];
            publicacion.FechaPublicacion = (DateTime)row[1];
            publicacion.Descripcion = (string)row[2];
            publicacion.FechaEvento = (DateTime)row[3];
            publicacion.Direccion = (string)row[5];

            EmpresaService empresaService = new EmpresaService();

        //    publicacion.Empresa = empresaService.GetEmpresa((int)row[8]);

          //  Console.WriteLine(row.Count);
        }
    }
}
