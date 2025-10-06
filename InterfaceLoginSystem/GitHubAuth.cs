using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoginSystem
{
    public class GitHubAuth : IAuthProvider
    {
        public void Login(string username)
        {
            Console.WriteLine($"[Github Login] Hoş geldin {username}, Github hesabıyla giriş yapıldı");
        }
    }
}
