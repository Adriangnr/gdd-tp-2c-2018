using System;
using System.Reflection;

namespace PalcoNet.Src.Modelo.Estados
{
    public class EstadoFactory
    {
        public static Estado getEstado(string estadoString)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.CreateInstance("PalcoNet.Src.Estados." + estadoString) as Estado;
        }
    }
}
