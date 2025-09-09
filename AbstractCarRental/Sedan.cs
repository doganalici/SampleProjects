using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCarRental
{
    public class Sedan : Vehicle
    {
        public override void CalculateRentalCost(int days)
        {
            Console.WriteLine("\t ----- SEDAN ARAÇ -----\n");
            double total = DailyPrice * days;
            Console.WriteLine($"Id : {Id}\n" +
                $"Marka : {Brand}\n" +
                $"Model : {Model}\n" +
                $"Renk : {Color}\n" +
                $"Günlük ücret : {DailyPrice}\n" +
                $"Kaç günlük kiralanacağı : {days}\n" +
                $"Günlük ücret uygulandı : {total:N0} TL");
            Console.WriteLine("****************************************\n");
        }
    }
}
