using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class WhatsAppNotification:Notification
    {
        public string GroupName { get; set; }
        public string PhoneNumber { get; set; }
        public override void Send()
        {
            Console.WriteLine($"WhatsApp mesajı gönderildi : {Message}\nAlıcı : {PhoneNumber}\nGönderim tarihi : {SendDate}\nGönderildiği grup : {GroupName}\nAciliyet durumu : {Priority}\n");
        }
    }
}
