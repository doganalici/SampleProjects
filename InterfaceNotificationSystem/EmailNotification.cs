using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNotificationSystem
{
    public class EmailNotification : INotification
    {
        public string Email { get; set; }
        public void SendNotification(string message)
        {
            Console.WriteLine($"{Email} mail adresine - {message} - mesajı gönderilmiştir");
        }
    }
}
