using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGameStore
{
    public class Game
    {
        public string GameName { get; set; }
        public int Price { get; set; }
        public double DiscountedPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
