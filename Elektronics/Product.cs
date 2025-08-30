using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronics
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public void TurnOn()
        {
            Console.WriteLine($"{Brand} markalı ürün açılmıştır.");
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Marka : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Renk : {Color}");
            Console.WriteLine($"Yıl : {Year}");
            
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Brand} markalı ürün kapatılmıştır");
        }
    }
}
