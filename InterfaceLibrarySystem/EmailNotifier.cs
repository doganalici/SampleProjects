using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrarySystem
{
    public class EmailNotifier : INotifier
    {
        public void Notify(string member, string message)
        {
            Console.WriteLine($"{member} kişisine email yoluyla - {message} - mesajı gönderilmiştir");
        }
    }
}
