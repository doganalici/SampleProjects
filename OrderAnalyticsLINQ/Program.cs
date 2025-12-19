using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAnalyticsLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>()
            {
                new Order(1, "Ahmet", "Laptop", "Elektronik", 25000, 1),
                new Order(2, "Ayşe", "Kulaklık", "Elektronik", 1500, 2),
                new Order(3, "Mehmet", "Ofis Sandalyesi", "Mobilya", 8000, 1),
                new Order(4, "Zeynep", "Masa", "Mobilya", 6000, 1),
                new Order(5, "Can", "Telefon", "Elektronik", 20000, 1),
                new Order(6, "Elif", "Defter", "Kırtasiye", 50, 10)
            };

            Console.WriteLine("ELEKTRONİK KATEGORİSİNDE OLAN ÜRÜNLER\n");
            var categories = orders.Where(o => o.Category == "Elektronik").ToList();
            foreach (var category in categories)
            {
                Console.WriteLine($"Id : {category.Id}\n" +
                                     $"Customer Name : {category.CustomerName}\n" +
                                     $"Product : {category.Product}\n" +
                                     $"Price : {category.Price:N0} TL");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }

            Console.WriteLine("SİPARİŞ KONTROLÜ\n");
            var order = orders.FirstOrDefault(o => o.CustomerName == "Ayşe");
            if (order == null)
            {
                Console.WriteLine("Ayşe adına ait bir sipariş bulunamadı.");
            }
            else
            {
                Console.WriteLine($"Sipariş Bulundu!\n" +
                                    $"Müşteri : {order.CustomerName}\n" +
                                    $"Ürün : {order.Product}\n" +
                                    $"Kategori : {order.Category}\n" +
                                    $"Fiyat : {order.Price:N0} TL\n" +
                                    $"Adet : {order.Quantity}");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }


            Console.WriteLine("ÜRÜN KONTROLÜ\n");
            var price = orders.FirstOrDefault(o => o.Price > 20000);
            if (price == null)
            {
                Console.WriteLine("10.000 TL üstünde sipariş bulunamadı.");
            }
            else
            {
                Console.WriteLine($"Ürün Bulundu!\n" +
                                    $"Müşteri : {price.CustomerName}\n" +
                                    $"Ürün : {price.Product}\n" +
                                    $"Kategori : {price.Category}\n" +
                                    $"Fiyat : {price.Price:N0} TL\n" +
                                    $"Adet : {price.Quantity}");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }


            Console.WriteLine("SİPARİŞ KONTROLÜ (SAYI OLARAK)\n");
            var count = orders.Count(o => o.Category == "Elektronik");
            Console.WriteLine($"Elektronik kategorisindeki ürün sayısı : {count}");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");


            Console.WriteLine("FİYATA GÖRE SIRALAMA\n");
            var sortedOrders = orders.OrderByDescending(o => o.Price).ToList();
            foreach (var s in sortedOrders)
            {
                Console.WriteLine($"Müşteri : {s.CustomerName}\n" +
                                    $"Ürün : {s.Product}\n" +
                                    $"Kategori : {s.Category}\n" +
                                    $"Fiyat : {s.Price:N0} TL\n" +
                                    $"Adet : {s.Quantity}");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }


            Console.WriteLine("MÜŞTERİ VE ÜRÜN ADI\n");
            var summary = orders.Select(o => new { o.CustomerName, o.Product }).ToList();
            foreach (var s in summary)
            {
                Console.WriteLine($"Müşteri : {s.CustomerName}\n" +
                    $"Ürün : {s.Product}");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
        }
    }
}
