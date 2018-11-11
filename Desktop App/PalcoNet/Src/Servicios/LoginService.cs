using System;
using PalcoNet.Src.Modelo.Entidades;

namespace PalcoNet.Src.Servicios
{
    class LoginService : DatabaseService
    {
        public int GetLogin(String username, String password)
        {
           Login loginEntity = new Login();
           return loginEntity.GetLogin(username, password);
        }
    }
}
