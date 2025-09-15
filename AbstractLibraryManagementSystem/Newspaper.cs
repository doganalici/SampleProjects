using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibraryManagementSystem
{
    public class Newspaper : LibraryItem
    {
        public DateTime PublishDate { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("  ---- GAZETE BİLGİLERİ ----\n");
            Console.WriteLine($"Id: {Id}\n" +
                $"Adı : {Name}\n" +
                $"Yazarı : {Author}\n" +
                $"Türü : {Type}\n" +
                $"Tarihi : {PublishDate:dd.MM.yyyy}\n" +
                $"Tutarı : {Price} TL");

        }
    }
}
