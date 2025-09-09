using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle sedan1 = new Sedan()
            {
                Id = 1,
                Brand = "Honda",
                Model = "Civic",
                Color ="Siyah",
                DailyPrice = 800
            };
            sedan1.CalculateRentalCost(4);//4 gün

            Vehicle sedan2 = new Sedan()
            {
                Id = 2,
                Brand = "Mercedes",
                Model = "C200",
                Color ="Gri",
                DailyPrice = 1000
            };
            sedan2.CalculateRentalCost(2);//2 gün

            Vehicle suv1 = new SUV()
            {
                Id = 3,
                Brand = "Toyota",
                Model = "Land Cruiser",
                Color="Mavi",
                DailyPrice = 1000
            };
            suv1.CalculateRentalCost(3);//3 gün

            Vehicle suv2 = new SUV()
            {
                Id = 4,
                Brand = "BMW",
                Model = "X5",
                Color="Beyaz",
                DailyPrice = 1500
            };
            suv2.CalculateRentalCost(5);//5 gün

            Vehicle truck1 = new Truck()
            {
                Id = 5,
                Brand = "Volvo",
                Model = "FH16",
                Color ="Siyah",
                DailyPrice = 2000
            };
            truck1.CalculateRentalCost(2);//2 gün

            Vehicle truck2 = new Truck()
            {
                Id = 6,
                Brand = "Scania",
                Model = "R500",
                Color ="Turuncu",
                DailyPrice = 2500
            };
            truck2.CalculateRentalCost(6);//6 gün

            List<Vehicle> vehicles = new List<Vehicle>() { sedan1, sedan2, suv1, suv2, truck1, truck2 };
            //foreach (Vehicle vehicle in vehicles)
            //{
            //    vehicle.CalculateRentalCost(1);
            //}
        }
    }
}
