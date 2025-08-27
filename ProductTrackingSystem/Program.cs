using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Kazak";
            product1.Price = 550;
            product1.Stock = 25;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Pantolon";
            product2.Price = 850;
            product2.Stock = 17;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Hırka";
            product3.Price = 700;
            product3.Stock = 22;

            var products = new Product[] { product1, product2, product3 };
            foreach (var product in products)
            {
                product.ProductInfo();
            }

            product2.Sell(5);
            product3.Restock(10);
          
        }
    }
}
