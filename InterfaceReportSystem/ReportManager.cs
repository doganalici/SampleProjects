using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceReportSystem
{
    public class ReportManager
    {
        List<IReport> reports = new List<IReport>();

        public void AddReport(IReport report)
        {
            reports.Add(report);
        }
        public void GenerateAll(string content)
        {
            foreach (var report in reports)
            {
                report.Generate(content);
            }
            Console.WriteLine("\n******************************************\n");
        }

        public void PrintAll()
        {
            foreach (var report in reports)
            {
                // Eğer bu rapor IPrintable ise cast ederek kullanıyoruz
                if (report is IPrintable printable)
                {
                    printable.Print();
                }
            }
            Console.WriteLine("\n******************************************\n");
        }
    }
}
