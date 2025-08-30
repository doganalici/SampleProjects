using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Id = 1;
            car1.Brand = "Volkswagen";
            car1.Model = "Passat";
            car1.Color = "Siyah";
            car1.Year = 2011;
            car1.FuelType = "Benzin";
            car1.Sunroof = true;

            Car car2 = new Car();
            car2.Id = 2;
            car2.Brand = "Toyota";
            car2.Model = "Corolla";
            car2.Color = "Gri";
            car2.Year = 2011;
            car2.FuelType = "Benzin/LPG";
            car2.Sunroof = false;

            var cars = new Car[] { car1, car2 };
            Console.WriteLine("\t***** ARABALARIN ÖZELLİKLERİ ****** \n");
            foreach (var car in cars)
            {
                car.CarInfo();
            }
            car1.Start();
            car2.Stop();

            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.Id = 3;
            motorcycle1.Brand = "Yamaha";
            motorcycle1.Model = "MT-07";
            motorcycle1.Color = "Mavi";
            motorcycle1.Year = 2022;
            motorcycle1.HasSideCar = false;

            Motorcycle motorcycle2=new Motorcycle();
            motorcycle2.Id = 4;
            motorcycle2.Brand = "Kawasaki";
            motorcycle2.Model = "Ninja 400";
            motorcycle2.Color = "Yeşil";
            motorcycle2.Year = 2021;
            motorcycle2.HasSideCar = false;

            var motorcycles = new Motorcycle[] {motorcycle1,motorcycle2};
            Console.WriteLine("\t***** MOTORLARIN ÖZELLİKLERİ ****** \n");
            foreach(var motorcycle in motorcycles)
            {
                motorcycle.MotorcycleInfo();
            }
            motorcycle1.Start();
            motorcycle1.DoWheelie();
            motorcycle2.Stop();
        }
    }
}
