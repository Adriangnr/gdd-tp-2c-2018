using System;
using System.Collections.Generic;

namespace PalcoNet.Servicios
{
    class LoginService : DatabaseService
    {
        public int GetLogin(String username, String password)
        {
           PalcoNet.Modelo.Entidades.Login loginEntity = new PalcoNet.Modelo.Entidades.Login();
           return loginEntity.GetLogin(username, password);
        }
    }
}
