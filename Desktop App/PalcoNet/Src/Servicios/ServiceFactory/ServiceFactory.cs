/*
 Tiene una lista de servicios para devolverle a los forms.
 Dependiendo que servicio necesite, el form va a tener 
 que castear lo que devuelve esta fabrica.
 */

using System;
using System.Collections.Generic;
using System.Reflection;

namespace PalcoNet.Src.Servicios.ServiceFactory
{
    public class ServiceFactory
    {
        private static Dictionary<String, DatabaseService> services = new Dictionary<String, DatabaseService>();
        
        public static DatabaseService GetService(String serviceName)
        {
            if (services.ContainsKey(serviceName))
            {
                return services[serviceName];
            }
            else
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                DatabaseService srv = assembly.CreateInstance("PalcoNet.Src.Servicios."+ serviceName) as DatabaseService;
                services.Add(serviceName, srv);
                return services[serviceName]; 
            }
        } 
    }
}
