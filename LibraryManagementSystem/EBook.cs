using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class EBook : Library
    {
        public int FileSize { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine("\t ***** E-KİTAP BİLGİLERİ ***** \n");

            Console.WriteLine($"Kitap Id : {Id}\n" +
                $"Kitap Adı : {Title}\n" +
                $"Kitap Yazarı : {Author}\n" +
                $"Kategorisi : {Category}\n" +
                $"Dosya Boyutu : {FileSize} MB\n" +
                $"Ücreti : {Price} TL\n");
            Console.WriteLine("---------------------------------------\n");
        }
    }
}
