using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Magazine : Library
    {
        public int IssueNumber { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine("\t ***** DERGİ BİLGİLERİ ***** \n");

            Console.WriteLine($"Kitap Id : {Id}\n" +
                $"Kitap Adı : {Title}\n" +
                $"Kitap Yazarı : {Author}\n" +
                $"Kategorisi : {Category}\n" +
                $"Sayı Numarası : {IssueNumber}\n" +
                $"Ücreti : {Price} TL\n");
            Console.WriteLine("---------------------------------------\n");
        }
    }
}
