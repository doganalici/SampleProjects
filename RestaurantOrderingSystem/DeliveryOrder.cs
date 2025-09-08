using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class DeliveryOrder : Order
    {
        public string Address { get; set; }

        public override void ProcessOrder()
        {
            Console.WriteLine("\t ***** TESLİMAT SİPARİŞİ *****\n");
            Console.WriteLine($"Siparişiniz {Address} adresine teslim edilecek.\n" +
                $"Sipariş Türü : {OrderType}\n" +
                $"Öncelik : {Priority}\n" +
                $"{CustomerName} isimli müşteri için toplam tutar : {TotalAmount} TL");
            Console.WriteLine("-----------------------------------------------------\n");
        }
    }
}
