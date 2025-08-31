using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Id = 1;
            book1.Title = "Sefiller";
            book1.Author = "Victor Hugo";
            book1.PageCount = 1200;
            book1.Genre = "Roman";


            Book book2 = new Book();
            book2.Id = 2;
            book2.Title = "Kürk Mantolu Madonna";
            book2.Author = "Sabahattin Ali";
            book2.PageCount = 160;
            book2.Genre = "Roman";

            Magazine magazine1 = new Magazine();
            magazine1.Id = 3;
            magazine1.Title = "National Geographic";
            magazine1.Author = "Çeşitli Yazarlar";
            magazine1.IssueNumber = 245;
            magazine1.Publisher = "National Geographic Society";

            Magazine magazine2 = new Magazine();
            magazine2.Id = 4;
            magazine2.Title = "Popular Science";
            magazine2.Author = "Çeşitli Yazarlar";
            magazine2.IssueNumber = 132;
            magazine2.Publisher = "Bonnier";

            Console.WriteLine("\t ----- KİTAP BİLGİLERİ ----- \n");
            var books = new Book[] { book1, book2 };
            foreach (Book book in books)
            {
                book.BookInfo();
            }

            Console.WriteLine("\t ----- DERGİ BİLGİLERİ ----- \n");
            var magazines=new Magazine[] { magazine1, magazine2 };
            foreach(Magazine magazine in magazines)
            {
                magazine.MagazineInfo();
            }
        }
    }
}
