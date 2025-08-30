using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public bool Sunroof { get; set; }

        public void CarInfo()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Marka : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Renk : {Color}");
            Console.WriteLine($"Yıl : {Year}");
            Console.WriteLine($"Yakıt Türü : {FuelType}");
            if (Sunroof)
            {
                Console.WriteLine("Sunroof : Var");
            }
            else
            {
                Console.WriteLine("Sunroof : Yok");
            }
            Console.WriteLine("\n********************************************\n");
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} markalı araç yola çıktı");
            Console.WriteLine("\n********************************************\n");

        }
    }
}
