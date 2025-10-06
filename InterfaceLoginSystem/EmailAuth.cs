using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoginSystem
{
    public class EmailAuth : IAuthProvider
    {
        public void Login(string username)
        {
            Console.WriteLine($"[Email Login] Hoş geldin {username}, e-posta ile giriş yapıldı");
        }
    }
}
