using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoggerSystem
{
    public class DatabaseLogger : ILogger
    {
        public string SqlName { get; set; }
        public void Log(string message)
        {
            Console.WriteLine($"{SqlName} veritabanına - {message} - mesajı loglandı");
        }
    }
}
