using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library book1 = new Book()
            {
                Id = 1,
                Title = "Suç ve Ceza",
                Author = "Fyodor Dostoyevski",
                Price = 120,
                Category = "Roman",
                PageCount = 600
            };
            Library book2 = new Book()
            {
                Id = 2,
                Title = "Nutuk",
                Author = "Mustafa Kemal Atatürk",
                Price = 150,
                Category = "Tarih",
                PageCount = 400
            };

            Library magazine1 = new Magazine()
            {
                Id = 3,
                Title = "Bilim ve Teknik",
                Author = "TÜBİTAK",
                Price = 30,
                Category = "Bilim",
                IssueNumber = 789
            };

            Library magazine2 = new Magazine()
            {
                Id = 4,
                Title = "National Geographic",
                Author = "NatGeo",
                Price = 45,
                Category = "Gezi",
                IssueNumber = 245
            };

            Library eBook1 = new EBook()
            {
                Id = 5,
                Title = "C# ile Programlama",
                Author = "Ahmet Yılmaz",
                Price = 90,
                Category = "Yazılım",
                FileSize = 5
            };

            Library eBook2 = new EBook()
            {
                Id = 6,
                Title = "Modern Web Geliştirme",
                Author = "Mehmet Demir",
                Price = 110,
                Category = "Teknoloji",
                FileSize = 8
            };

            List<Library> libraries = new List<Library>() { book1, book2, magazine1, magazine2, eBook1, eBook2 };

            foreach (Library library in libraries)
            {
                library.DisplayInfo();
            }
        }
    }
}
