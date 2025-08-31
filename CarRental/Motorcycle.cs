using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Motorcycle : Vehicle
    {
        public int EngineCC { get; set; }

        public void MotorcycleInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Motor Gücü : {EngineCC}");
            Console.WriteLine("\n**********************************\n");
        }
    }
}
