using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class TakeAwayOrder : Order
    {
        public DateTime PickupTime { get; set; } = DateTime.Now;
        public override void ProcessOrder()
        {
            Console.WriteLine("\t ***** PAKET SİPARİŞİ *****\n");
            Console.WriteLine($"Siparişiniz {PickupTime} içinde hazır olacak.\n" +
                $"Sipariş Türü : {OrderType}\n" +
                $"Öncelik : {Priority}\n" +
                $"Teslimat süresi : {PickupTime.ToString("HH:mm")}\n"+
                $"{CustomerName} isimli müşteri için toplam tutar : {TotalAmount} TL");
            Console.WriteLine("-----------------------------------------------------\n");

        }
    }
}
