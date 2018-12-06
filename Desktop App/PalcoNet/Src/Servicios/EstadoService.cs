using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Modelo.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Servicios
{
    public class EstadoService : DatabaseService
    {
        public List<Estado> GetEstados()
        {
            List<Estado> estados = new List<Estado>() {
                    new Borrador(),
                    new Publicada(),
                    new Finalizada()
            };

            return estados;
        }
    }
}
