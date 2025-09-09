using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCarRental
{
    public abstract class Vehicle
    {
        public int Id { get; set; } //id
        public string Brand { get; set; } //marka
        public string Model { get; set; } //model
        public string Color { get; set; } //renk
        public double DailyPrice { get; set; } //günlük ücret

        public abstract void CalculateRentalCost(int days);
    }
}
