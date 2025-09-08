using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class DineInOrder : Order
    {
        public int TableNumber { get; set; }
        public override void ProcessOrder()
        {
            Console.WriteLine("\t ***** YEMEK SİPARİŞİ *****\n");
            Console.WriteLine($"Masa numarası {TableNumber} için sipariş hazırlandı.\n" +
                $"Sipariş Türü : {OrderType}\n" +
                $"Öncelik : {Priority}\n" +
                $"{CustomerName} isimli müşteri için toplam tutar : {TotalAmount} TL");
            Console.WriteLine("-----------------------------------------------------\n");
        }
    }
}
