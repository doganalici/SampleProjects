using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNotificationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1) Manager örneği oluşturuyoruz — tüm bildirimleri buradan yöneteceğiz.
            NotificationManager notificationManager = new NotificationManager();

            // 2) Farklı türde bildirim nesneleri oluşturup manager'a ekliyoruz.
            // object initializer kullandın: new EmailNotification { Email = "example@mail.com" }
            // bu, Email özelliğine doğrudan değer atıyor.
            notificationManager.AddNotification(new EmailNotification { Email = "example@mail.com" });
            notificationManager.AddNotification(new SmsNotification { PhoneNumber = "+905555555555" });
            notificationManager.AddNotification(new PushNotification { DeviceId = "device-13" });
            notificationManager.AddNotification(new EmailNotification { Email = "test@mail.com" });

            Console.WriteLine("Bildirimler gönderiliyor...");
            Console.WriteLine("*********************************\n");

            // 3) Manager'ın SendAll'ini çağırıyoruz; tüm ekli bildirimlere message gönderilecek.
            notificationManager.SendAll("Merhaba! Bu bir test mesajıdır");
            Console.WriteLine("\n-------------------------------\n");
            notificationManager.SendAll("Yeni kampanyamız başladı!");

            Console.WriteLine("\n*** Sadece SMS gönderiliyor ***\n");
            notificationManager.SendByType("sms", "Sadece SMS abonelerine özel kampanya!");
            Console.WriteLine("\n-------------------------------\n");
            Console.WriteLine("\n*** Sadece Email gönderiliyor ***\n");
            notificationManager.SendByType("mail", "Sadece Email abonelerine özel kampanya!");
            Console.WriteLine("\n-------------------------------\n");
            Console.WriteLine("\n*** Sadece Push gönderiliyor ***\n");
            notificationManager.SendByType("push", "Sadece Push abonelerine özel kampanya!");
            Console.WriteLine("\n-------------------------------\n");


        }
    }
}
