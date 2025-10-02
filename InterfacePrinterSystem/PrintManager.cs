using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinterSystem
{
    public class PrintManager
    {
        private readonly IPrinter _printer;

        public PrintManager(IPrinter printer)
        {
            _printer = printer;
        }
        public void PrintDocument(string message)
        {
            _printer.Print(message);
            Console.WriteLine("-------------------------");
        }
    }
}
