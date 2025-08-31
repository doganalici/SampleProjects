using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public void ShowBaseInfo()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Kitap Adı : {Title}");
            Console.WriteLine($"Yazar : {Author}");
        }
    }
}
