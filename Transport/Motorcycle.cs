using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public void MotorcycleInfo()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Marka : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Renk : {Color}");
            Console.WriteLine($"Yıl : {Year}");
            if (HasSideCar)
            {
                Console.WriteLine("Yan Koltuk : Var");
            }
            else
            {
                Console.WriteLine("Yan Koltuk : Yok");
            }
            Console.WriteLine("\n********************************************\n");
        }
        public void DoWheelie()
        {
            Console.WriteLine($"{Brand} marka motosiklet wheelie yaptı!");
            Console.WriteLine("\n********************************************\n");
        }
    }
}
