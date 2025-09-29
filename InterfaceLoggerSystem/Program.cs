using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoggerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggerManager loggerManager = new LoggerManager();
            loggerManager.AddLogger(new ConsoleLogger());
            loggerManager.AddLogger(new FileLogger { FileName = "log.txt" });
            loggerManager.AddLogger(new DatabaseLogger { SqlName = "Sql" });
            loggerManager.AddLogger(new EmailLogger { Email = "example@mail.com" });

            Console.WriteLine("Loglar gönderiliyor...");
            Console.WriteLine("-----------------------------\n");

            loggerManager.LogAll("Bir uygulama başlatıldı");
            loggerManager.LogAll("Bir hata meydana geldi");
            loggerManager.LogAll("Uygulama kapatılıyor");
            

        }
    }
}
