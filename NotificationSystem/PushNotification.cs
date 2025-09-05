using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class PushNotification:Notification
    {
        public string DeviceId { get; set; }
        public override void Send()
        {
            Console.WriteLine($"Push bildirimi gönderildi : {Message}\nCihaz No : {DeviceId}\nGönderim tarihi : {SendDate}\nAciliyet durumu : {Priority}\n");
        }
    }
}
