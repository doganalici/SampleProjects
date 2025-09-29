using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoggerSystem
{
    public class FileLogger : ILogger
    {
        public string FileName { get; set; }
        public void Log(string message)
        {
            Console.WriteLine($"{FileName} dosyasına - {message} - mesajı loglandı");
        }
    }
}
