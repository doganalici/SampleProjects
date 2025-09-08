using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int TotalAmount { get; set; }
        public string Priority { get; set; }
        public string OrderType { get; set; }

        public virtual void ProcessOrder()
        {
            Console.WriteLine($"Sipariş işleniyor: {CustomerName} için toplam {TotalAmount} TL.\n" +
                $"Sipariş Türü : {OrderType}\n" +
                $"Öncelik : {Priority}");
        }
    }
}
