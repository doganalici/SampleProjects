using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinterSystem
{
    public class PdfPrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"Pdf dosyadan - {message} - mesajı yazdırılmıştır");
        }
    }
}
