using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCarRental
{
    public class Truck : Vehicle
    {
        public override void CalculateRentalCost(int days)
        {
            Console.WriteLine("\t ----- KAMYON TİPİ ARAÇ -----\n");
            double total = (DailyPrice + 100) * days;
            Console.WriteLine($"Id : {Id}\n" +
                $"Marka : {Brand}\n" +
                $"Model : {Model}\n" +
                $"Renk : {Color}\n" +
                $"Günlük ücret : {DailyPrice}\n" +
                $"Kaç günlük kiralanacağı : {days}\n" +
                $"Günlük ücret + Yük ücreti : {total:N0} TL");
            Console.WriteLine("****************************************\n");
        }
    }
}
