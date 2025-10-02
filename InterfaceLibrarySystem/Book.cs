using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrarySystem
{
    public class Book:IBookBorrowable
    {
        public string Title { get; set; }

        public void Borrow(string member)
        {
            Console.WriteLine($"{Title} isimli kitap {member} adlı kişi tarafından alınmıştır");
        }

        public void Return(string member)
        {
            Console.WriteLine($"{Title} isimli kitabı {member} adlı kişi tarafından iade edilmiştir ");
        }
    }
}
