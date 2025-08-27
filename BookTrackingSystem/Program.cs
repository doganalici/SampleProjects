using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Test1";
            book1.Author = "Yazar1";
            book1.PageCount = 500;
            book1.IsRead = false;

            Book book2 = new Book();
            book2.Title = "Test2";
            book2.Author = "Yazar2";
            book2.PageCount = 650;
            book2.IsRead = false;

            Book book3 = new Book();
            book3.Title = "Test3";
            book3.Author = "Yazar3";
            book3.PageCount = 275;
            book3.IsRead = true;

            var books = new Book[] { book1, book2, book3 };
            foreach (var book in books)
            {
                book.BookInfo();
            }
            book2.MarkAsRead();
            book2.BookInfo();
        }
    }
}
