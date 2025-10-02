using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinterSystem
{
    public class HtmlPrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"Html dosyadan - {message} - mesajı yazdırılmıştır");
        }
    }
}
