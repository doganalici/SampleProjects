using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoginSystem
{
    public class LoginManager
    {
        private readonly IAuthProvider _authProvider;

        public LoginManager(IAuthProvider authProvider)
        {
            _authProvider=authProvider;
        }

        public void Authenticate(string username)
        {
            _authProvider.Login(username);
        }
    }
}
