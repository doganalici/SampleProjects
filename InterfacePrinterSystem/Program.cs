using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrinterSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintManager printManager=new PrintManager(new PdfPrinter());
            printManager.PrintDocument("C# Interface dersi notları");

            PrintManager printManager2 = new PrintManager(new WordPrinter());
            printManager2.PrintDocument("OOP mantığını kavrama çalışması");


            PrintManager printManager3=new PrintManager(new ExcelPrinter());
            printManager3.PrintDocument("Github yüklenecek proje");


            PrintManager printManager4=new PrintManager(new HtmlPrinter());
            printManager4.PrintDocument("Proje örnek kodları");




        }
    }
}
