using PalcoNet.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace PalcoNet.Servicios
{
    class UserService : DatabaseService
    {
        public Usuario GetUser(String username)
        {
            return new Usuario(username);
        }

        public void saveUser(Dictionary<string, string> userParams)
        {

        }
    }
}
