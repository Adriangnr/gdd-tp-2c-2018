using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Utils
{
    public class Utilities
    {
        public static Object createInstance(string classFullName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.CreateInstance(classFullName);
        }
    }
}
