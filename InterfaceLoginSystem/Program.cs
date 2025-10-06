using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoginSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginManager email = new LoginManager(new EmailAuth());
            email.Authenticate("example@hotmail.com");

            LoginManager google = new LoginManager(new GoogleAuth());
            google.Authenticate("exampleaccount");

            LoginManager github = new LoginManager(new GitHubAuth());
            github.Authenticate("githubexample");
        }
    }
}
