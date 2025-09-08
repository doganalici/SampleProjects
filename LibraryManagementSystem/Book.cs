using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : Library
    {
        public int PageCount { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine("\t ***** KİTAP BİLGİLERİ ***** \n");

            Console.WriteLine($"Kitap Id : {Id}\n" +
                $"Kitap Adı : {Title}\n" +
                $"Kitap Yazarı : {Author}\n" +
                $"Kategorisi : {Category}\n" +
                $"Sayfa Sayısı : {PageCount}\n" +
                $"Ücreti : {Price} TL\n");
            Console.WriteLine("---------------------------------------\n");
        }
    }
}
