using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class SmsNotification:Notification
    {
        public string PhoneNumber { get; set; }
        public override void Send()
        {
            Console.WriteLine($"Sms gönderildi : {Message}\nAlıcı : {PhoneNumber}\nGönderim tarihi : {SendDate}\nAciliyet durumu : {Priority}\n");
        }
    }
}
