using System;
using System.Reflection;

namespace PalcoNet.Src.Modelo.Estados
{
    public class EstadoFactory
    {
        public static Estado getEstado(string estadoString)
        {
            return Utils.Utilities.createInstance("PalcoNet.Src.Modelo.Estados." + estadoString) as Estado;
        }
    }
}
