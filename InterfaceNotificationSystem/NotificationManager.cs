using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNotificationSystem
{
    public class NotificationManager
    {
        // Bu liste, INotification tipinde nesneler tutuyor.
        // INotification'ı implement eden (uygulayan) her sınıfı buraya ekleyebilirsin:
        // EmailNotification, SmsNotification, PushNotification vb.
        List<INotification> notifications = new List<INotification>();

        // Yeni bir bildirim objesini listeye ekleyen metod.
        public void AddNotification(INotification notification)
        {
            notifications.Add(notification);
        }

        // Listedeki bütün bildirimleri gönderir.
        public void SendAll(string message)
        {
            foreach (var notification in notifications)
            {
                // Burada INotification arayüzündeki SendNotification çağrılıyor.
                // Hangi somut sınıf (Email, SMS, Push) eklendiyse,
                // onun SendNotification() implementasyonu çalışır.
                notification.SendNotification(message);
            }

        }
        public void SendByType(string type, string message)
        {
            foreach (var notification in notifications)
            {
                if (type == "mail" && notification is EmailNotification)
                {
                    notification.SendNotification(message);
                }
                else if (type == "sms" && notification is SmsNotification)
                {
                    notification.SendNotification(message);
                }
                else if (type == "push" && notification is PushNotification)
                {
                    notification.SendNotification(message);
                }

            }
        }
    }
}
