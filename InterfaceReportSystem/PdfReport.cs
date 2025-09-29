using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceReportSystem
{
    public class PdfReport : IReport,IPrintable
    {
        public void Generate(string content)
        {
            Console.WriteLine($"PDF oluşturuldu : {content}");
        }

        public void Print()
        {
            Console.WriteLine("Pdf dosya yazdırıldı");
        }
    }
}
