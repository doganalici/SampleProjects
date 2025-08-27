using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public void ProductInfo()
        {
            Console.WriteLine($"Ürün Id : {Id}");
            Console.WriteLine($"Ürün Adı : {Name}");
            Console.WriteLine($"Ürün Fiyatı : {Price} TL");
            Console.WriteLine($"Ürün Stok Miktarı : {Stock}");
            Console.WriteLine("\n***************************************\n");
        }
        public void Sell(int quantity)
        {
            if (quantity < 1 || quantity > Stock)
            {
                Console.WriteLine("Yeterli stok yok ya da hatalı satış sayısı yazıldı!");
            }
            else
            {
                Stock -= quantity;
                Console.WriteLine($"{Name} ürününden {quantity} adet satış gerçekleşti.");
                ProductInfo();
            }
        }
        public void Restock(int quantity)
        {
            if (quantity < 1)
            {
                Console.WriteLine("Hatalı stok girişi yapıldı!");
            }
            else
            {
                Stock += quantity;
                Console.WriteLine($"{Name} ürününden {quantity} adet stok eklemesi gerçekleşti.");
                ProductInfo();
            }
        }
    }
}
