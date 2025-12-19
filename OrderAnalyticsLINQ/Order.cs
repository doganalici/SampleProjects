using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAnalyticsLINQ
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Order(int id,string customerName,string product,string category,decimal price,int quantity)
        {
            this.Id = id;
            this.CustomerName = customerName;
            this.Product = product;
            this.Category = category;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
