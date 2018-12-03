

using PalcoNet.Src.Modelo.Daos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PalcoNet.Src.Servicios
{
    public class PublicacionService : DatabaseService
    {
        private DaoPublicacion daoPublicaion = new DaoPublicacion();

        public List<List<object>> SearchActivasValidas(Control.ControlCollection filtros)
        {
            return this.daoPublicaion.SearchActivasValidas(filtros);
        }
    }
}
