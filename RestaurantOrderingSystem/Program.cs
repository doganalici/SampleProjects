using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order dineIn1 = new DineInOrder()
            {
                Id = 1,
                CustomerName = "Ahmet",
                TotalAmount = 150,
                TableNumber = 5,
                Priority = "Yüksek",
                OrderType = "Yemek Siparişi"
            };

            Order dineIn2 = new DineInOrder()
            {
                Id = 2,
                CustomerName = "Ayşe",
                TotalAmount = 200,
                TableNumber = 3,
                Priority = "Normal",
                OrderType = "Yemek Siparişi"
            };

            Order takeAway1 = new TakeAwayOrder()
            {
                Id = 3,
                CustomerName = "Mehmet",
                TotalAmount = 80,
                PickupTime = DateTime.Now.AddMinutes(30),
                Priority = "Düşük",
                OrderType = "Paket Siparişi"
            };

            Order takeAway2 = new TakeAwayOrder()
            {
                Id = 4,
                CustomerName = "Fatma",
                TotalAmount = 60,
                PickupTime = DateTime.Now.AddMinutes(15),
                Priority = "Normal",
                OrderType = "Paket Siparişi"
            };

            Order delivery1 = new DeliveryOrder()
            {
                Id = 5,
                CustomerName = "Ali",
                TotalAmount = 120,
                Address = "İstanbul, Kadıköy",
                Priority = "Yüksek",
                OrderType = "Teslimat Siparişi"
            };

            Order delivery2 = new DeliveryOrder()
            {
                Id = 6,
                CustomerName = "Selin",
                TotalAmount = 90,
                Address = "İzmir, Konak",
                Priority = "Normal",
                OrderType = "Teslimat Siparişi"
            };

            List<Order> orders = new List<Order>()
            {
                dineIn1,dineIn2,takeAway1,takeAway2,delivery1,delivery2
            };

            foreach (Order order in orders)
            {
                order.ProcessOrder();
            }


        }
    }
}
