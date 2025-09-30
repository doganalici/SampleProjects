using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public class EmailNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Mail yoluyla {to} kişisine - {message} - mesajı gönderilmiştir");
        }
    }
}
