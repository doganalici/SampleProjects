using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class Notification
    {
        public string Message { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
        public string Priority { get; set; } //Aciliyet Durumu : "Yüksek" , "Normal" , "Düşük"s
        public virtual void Send()
        {
            Console.WriteLine("Bildirim gönderiliyor....");
        }
    }
}
