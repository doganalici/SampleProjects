using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinterSystem
{
    public class ExcelPrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"Excel dosyadan - {message} - mesajı yazdırılmıştır");
        }
    }
}
