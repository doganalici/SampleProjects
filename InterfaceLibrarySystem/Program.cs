using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book() { Title = "Suç ve Ceza" };
            INotifier notifier = new EmailNotifier();

            var librayManager=new LibraryManager(book, notifier);
            librayManager.BorrowBook("Doğan Alıcı");
            Console.WriteLine("\n----------------------------------\n");
            librayManager.ReturnBook("Doğan Alıcı");
        }
    }
}
