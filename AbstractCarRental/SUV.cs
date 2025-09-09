using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCarRental
{
    public class SUV : Vehicle
    {
        public override void CalculateRentalCost(int days)
        {
            Console.WriteLine("\t ----- SUV ARAÇ -----\n");
            double total = ((DailyPrice * 0.2) + DailyPrice)*days;
            Console.WriteLine($"Id : {Id}\n" +
                $"Marka : {Brand}\n" +
                $"Model : {Model}\n" +
                $"Renk : {Color}\n" +
                $"Günlük ücret : {DailyPrice}\n" +
                $"Kaç günlük kiralanacağı : {days}\n" +
                $"Günlük ücret + %20 SUV ücreti : {total:N0} TL");
            Console.WriteLine("****************************************\n");
        }
    }
}
