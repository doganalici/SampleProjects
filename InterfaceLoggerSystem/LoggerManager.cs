using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLoggerSystem
{
    public class LoggerManager
    {
        List<ILogger> loggers = new List<ILogger>();
        public void AddLogger(ILogger logger)
        {
            loggers.Add(logger);
        }

        public void LogAll(string message)
        {
            foreach (var logger in loggers)
            {
               logger.Log(message);
            }
            Console.WriteLine("\n******************************\n");
        }
    }
}
