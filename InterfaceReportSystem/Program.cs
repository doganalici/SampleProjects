using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportManager reportManager = new ReportManager();
            reportManager.AddReport(new PdfReport());
            reportManager.AddReport(new ExcelReport());
            reportManager.AddReport(new WordReport());

            reportManager.GenerateAll("Satış Raporu");
            reportManager.GenerateAll("Aylık Performans Raporu");
            reportManager.PrintAll();
        }
    }
}
