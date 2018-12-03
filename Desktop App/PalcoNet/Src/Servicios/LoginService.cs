using System;
using PalcoNet.Src.Modelo.Daos;

namespace PalcoNet.Src.Servicios
{
    class LoginService : DatabaseService
    {
        public int GetLogin(String username, String password)
        {
           DaoLogin loginEntity = new DaoLogin();
           return loginEntity.GetLogin(username, password);
        }
    }
}
