using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryItem library1 = new Book()
            {
                Id = 1,
                Name = "Suç ve Ceza",
                Author = "Dostoyevski",
                Type = "Roman",
                Page = 550,
                Price = 120
            };

            LibraryItem library2 = new Book()
            {
                Id = 2,
                Name = "Sefiller",
                Author = "Victor Hugo",
                Type = "Roman",
                Page = 680,
                Price = 150
            };

            LibraryItem magazine1 = new Magazine()
            {
                Id = 3,
                Name = "Bilim ve Teknik",
                Author = "TÜBİTAK",
                Type = "Bilim",
                IssueNumber = 202,
                Price = 50
            };

            LibraryItem magazine2 = new Magazine()
            {
                Id = 4,
                Name = "National Geographic",
                Author = "NG Publishing",
                Type = "Gezi / Doğa",
                IssueNumber = 305,
                Price = 70
            };

            LibraryItem ebook1 = new EBook()
            {
                Id = 5,
                Name = "Clean Code",
                Author = "Robert C. Martin",
                Type = "Yazılım",
                FileSizeMB = 5,
                Price = 90
            };

            LibraryItem ebook2 = new EBook()
            {
                Id = 6,
                Name = "Design Patterns",
                Author = "Erich Gamma",
                Type = "Yazılım",
                FileSizeMB = 8,
                Price = 110
            };

            LibraryItem newspaper1 = new Newspaper()
            {
                Id = 7,
                Name = "Hürriyet",
                Author = "Hürriyet Yayıncılık",
                Type = "Günlük Gazete",
                PublishDate = new DateTime(2025, 9, 15),
                Price = 15
            };

            LibraryItem newspaper2 = new Newspaper()
            {
                Id = 8,
                Name = "The New York Times",
                Author = "NYT Company",
                Type = "Günlük Gazete",
                PublishDate = new DateTime(2025, 9, 14),
                Price = 20
            };


            List<LibraryItem> libraries = new List<LibraryItem>() { library1, library2, magazine1, magazine2, ebook1, ebook2, newspaper1, newspaper2 };
            foreach (LibraryItem library in libraries)
            {
                library.ShowInfo();
                Console.WriteLine("************************************\n");
            }

        }
    }
}
