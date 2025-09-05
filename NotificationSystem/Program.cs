using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification emailNotification1 = new EmailNotification()
            {
                Message = "Toplantı saat 14:00'te başlayacak.",
                Email = "ali@example.com",
                Priority="Yüksek"
               
            };

            Notification emailNotification2 = new EmailNotification()
            {
                Message = "Yeni duyuru yayında!",
                Email = "ayse@example.com",
                Priority = "Düşük"
            };

            Notification smsNotification1 = new SmsNotification()
            {
                Message = "Şifre sıfırlama kodunuz: 123456",
                PhoneNumber = "+905551112233",
                Priority = "Normal"
            };

            Notification smsNotification2 = new SmsNotification()
            {
                Message = "Siparişiniz kargoya verildi.",
                PhoneNumber = "+905556667788",
                Priority = "Normal"
            };

            Notification pushNotification1 = new PushNotification()
            {
                Message = "Uygulama güncellemesi mevcut.",
                DeviceId = "device123",
                Priority = "Yüksek"
            };

            Notification pushNotification2 = new PushNotification()
            {
                Message = "Yeni mesajınız var!",
                DeviceId = "device456",
                Priority = "Düşük"
            };

            Notification whatsappNotification1 = new WhatsAppNotification()
            {
                Message = "Toplantı 10 dakika içinde başlayacak.",
                PhoneNumber = "+905551234567",
                GroupName = "Yazılım Ekibi",
                Priority="Yüksek"
            };

            Notification whatsappNotification2 = new WhatsAppNotification()
            {
                Message = "Akşam yemeği için rezervasyon yapıldı.",
                PhoneNumber = "+905559876543",
                GroupName = "Aile Grubu",
                Priority = "Normal"
            };

            List<Notification> notifications = new List<Notification>()
            {
                emailNotification1,emailNotification2,smsNotification1,smsNotification2,pushNotification1,pushNotification2,whatsappNotification1,whatsappNotification2
            };
            foreach (Notification notification in notifications)
            {
                Console.WriteLine("**************************************************************************");
                notification.Send();
            }
        }
    }
}
