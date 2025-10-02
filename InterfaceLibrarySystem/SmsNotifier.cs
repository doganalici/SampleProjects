using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrarySystem
{
    public class SmsNotifier : INotifier
    {
        public void Notify(string member, string message)
        {
            Console.WriteLine($"{member} kişisine sms yoluyla - {message} - mesajı gönderilmiştir");
        }
    }
}
