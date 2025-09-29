using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoggerSystem
{
    public class EmailLogger : ILogger
    {
        public string Email { get; set; }
        public void Log(string message)
        {
            Console.WriteLine($"{Email} adresine -  {message} - mesajı loglandı");
        }
    }
}
