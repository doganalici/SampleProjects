using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoginSystem
{
    public class GoogleAuth : IAuthProvider
    {
        public void Login(string username)
        {
            Console.WriteLine($"[Google Login] Hoş geldin {username}, Google hesabıyla giriş yapıldı");
        }
    }
}
