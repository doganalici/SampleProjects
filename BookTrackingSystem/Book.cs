using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackingSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public bool IsRead { get; set; }


        public void BookInfo()
        {
            Console.WriteLine($"Kitabın Adı : {Title}");
            Console.WriteLine($"Kitabın Yazarı : {Author}");
            Console.WriteLine($"Kitabın Sayfa Sayısı : {PageCount}");
            if (IsRead == true)
            {
                Console.WriteLine("Kitap Okundu");
            }
            else
            {
                Console.WriteLine("Kitap Okunmadı");
            }
            Console.WriteLine("\n*******************************\n");
        }
        public void MarkAsRead()
        {
            IsRead = true;
            Console.WriteLine("Kitap okundu olarak işaretlendi!");
        }
    }
}
