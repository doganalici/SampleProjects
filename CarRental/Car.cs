using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Car : Vehicle
    {
        public int PassangerCapacity { get; set; }
        public string FuelType { get; set; }

        public void CarInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Yolcu Kapasitesi : {PassangerCapacity}");
            Console.WriteLine($"Yakıt Türü : {FuelType}");
            Console.WriteLine("\n**********************************\n");
        }
    }
}
