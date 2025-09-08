using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id : {Id}\n" +
                $"Adı : {Title}\n" +
                $"Yazarı : {Author}\n" +
                $"Kategorisi : {Category}\n" +
                $"Ücreti : {Price} TL\n");
        }
    }
}
