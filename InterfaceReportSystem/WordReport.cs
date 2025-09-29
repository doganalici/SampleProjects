using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceReportSystem
{
    public class WordReport : IReport,IPrintable
    {
        public void Generate(string content)
        {
            Console.WriteLine($"Word raporu oluşturuldu : {content}");
        }

        public void Print()
        {
            Console.WriteLine("Word dosyası yazdırılıldı");
        }
    }
}
