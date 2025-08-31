using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void ShowBaseInfo()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Marka : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Yıl : {Year}");
        }
    }
}
