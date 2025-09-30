using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public class SmsNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sms yoluyla {to} kişisine - {message} - mesajı gönderilmiştir");

        }
    }
}
