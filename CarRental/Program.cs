using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Id = 1;
            car1.Brand = "Volkswagen";
            car1.Model = "Passat";
            car1.Year = 2011;
            car1.PassangerCapacity = 5;
            car1.FuelType = "Benzin";

            Car car2 = new Car();
            car2.Id = 2;
            car2.Brand = "Toyota";
            car2.Model = "Corolla";
            car2.Year = 2011;
            car2.PassangerCapacity = 5;
            car2.FuelType = "Benzin/LPG";


            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.Id = 3;
            motorcycle1.Brand = "Yamaha";
            motorcycle1.Model = "R25";
            motorcycle1.Year = 2021;
            motorcycle1.EngineCC = 250;

            Motorcycle motorcycle2 = new Motorcycle();
            motorcycle2.Id = 4;
            motorcycle2.Brand = "Kawasaki";
            motorcycle2.Model = "Ninja 400";
            motorcycle2.Year = 2022;
            motorcycle2.EngineCC = 400;

            Truck truck1 = new Truck();
            truck1.Id = 5;
            truck1.Brand = "Mercedes";
            truck1.Model = "Actros";
            truck1.Year = 2019;
            truck1.LoadCapacity = 18000;

            Truck truck2 = new Truck();
            truck2.Id = 6;
            truck2.Brand = "Volvo";
            truck2.Model = "FH16";
            truck2.Year = 2020;
            truck2.LoadCapacity = 20000;

            Console.WriteLine("\t ----- ARABALARIN ÖZELLİKLERİ ----- \n");
            var cars = new Car[] { car1, car2 };
            foreach (Car car in cars)
            {
                car.CarInfo();
            }

            Console.WriteLine("\t ----- MOTORLARIN ÖZELLİKLERİ ----- \n");
            var motorcycles = new Motorcycle[] { motorcycle1, motorcycle2 };
            foreach (Motorcycle motorcycle in motorcycles)
            {
                motorcycle.MotorcycleInfo();
            }

            Console.WriteLine("\t ----- TIRLARIN ÖZELLİKLERİ ----- \n");
            var trucks = new Truck[] { truck1, truck2 };
            foreach (Truck truck in trucks)
            {
                truck.TruckInfo();
            }
        }
    }
}
