using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibraryManagementSystem
{
    public class Book : LibraryItem
    {
        public int Page { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("  ---- KİTAP BİLGİLERİ ----\n");
            Console.WriteLine($"Id: {Id}\n" +
                $"Adı : {Name}\n" +
                $"Yazarı : {Author}\n" +
                $"Türü : {Type}\n" +
                $"Sayfa Sayısı : {Page}\n" +
                $"Tutarı : {Price} TL");
           
        }
    }
}
