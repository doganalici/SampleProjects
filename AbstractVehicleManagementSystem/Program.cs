using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicleManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Car()
            {
                Id = 1,
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2020,
                Price = 600000,
                FuelType = "Benzin"
            };
            Vehicle car2 = new Car()
            {
                Id = 2,
                Brand = "Honda",
                Model = "Civic",
                Year = 2019,
                Price = 550000,
                FuelType = "Dizel"
            };

            Vehicle motorcycle1 = new Motorcycle()
            {
                Id = 3,
                Brand = "Yamaha",
                Model = "R25",
                Year = 2021,
                Price = 200000,
                EngineCapacity = "250cc"
            };

            Vehicle motorcycle2 = new Motorcycle()
            {
                Id = 4,
                Brand = "Kawasaki",
                Model = "Ninja 400",
                Year = 2022,
                Price = 300000,
                EngineCapacity = "400cc"
            };

            Vehicle truck1 = new Truck()
            {
                Id = 5,
                Brand = "Mercedes",
                Model = "Actros",
                Year = 2018,
                Price = 1200000,
                LoadCapacity = 20
            };

            Vehicle truck2 = new Truck()
            {
                Id = 6,
                Brand = "Volvo",
                Model = "FH16",
                Year = 2020,
                Price = 1500000,
                LoadCapacity = 25
            };

            List<Vehicle> vehicles = new List<Vehicle>() { car1, car2, motorcycle1, motorcycle2, truck1, truck2 };
            vehicles.Add(new Car()
            {
                Id = 7,
                Brand = "BMW",
                Model = "3.20i",
                Year = 2021,
                Price = 900000,
                FuelType = "Benzin"
            });

            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
                
            }
            Console.WriteLine($"2.araç : {vehicles.Find(i=>i.Id==2).Brand}");
            Console.WriteLine($"Listedeki araç sayısı : {vehicles.Count()}");

        }
    }
}
