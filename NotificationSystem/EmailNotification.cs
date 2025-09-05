using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class EmailNotification:Notification
    {
        public string Email { get; set; }
        public override void Send()
        {
            Console.WriteLine($"Email gönderildi : {Message}\nAlıcı : {Email}\nGönderim tarihi : {SendDate}\nAciliyet durumu : {Priority}\n");
        }
    }
}
