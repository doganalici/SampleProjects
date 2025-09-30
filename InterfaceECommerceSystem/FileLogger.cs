using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Fatura - {message} - mesajı ile dosyaya loglanmıştır");
        }
    }
}
