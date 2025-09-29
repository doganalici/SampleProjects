using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceReportSystem
{
    public class ExcelReport : IReport
    {
        public void Generate(string content)
        {
            Console.WriteLine($"Excel raporu oluşturuldu : {content}");
        }
    }
}
