using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNotificationSystem
{
    public class PushNotification:INotification
    {
        public string DeviceId { get; set; }

        public void SendNotification(string message)
        {
            Console.WriteLine($"Mobil push ile {DeviceId} cihazından - {message} - mesajı gönderilmiştir.");
        }
    }
}
