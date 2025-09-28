using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNotificationSystem
{
    public class SmsNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS ile {PhoneNumber} numarasına - {message} - mesajı gönderilmiştir.");
        }
    }
}
