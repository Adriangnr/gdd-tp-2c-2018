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
            SortableBindingList<Publicacion> publicaciones = new SortableBindingList<Publicacion>();


            return publicaciones;
        }
    }
}
