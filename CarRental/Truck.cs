using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public void TruckInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Yük taşıma kapasitesi : {LoadCapacity}");
            Console.WriteLine("\n**********************************\n");

        }
    }
}
