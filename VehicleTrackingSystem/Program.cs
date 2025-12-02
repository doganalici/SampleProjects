using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTrackingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();


            carManager.AddCar(new Car(1, "Toyota", "Corolla", 2011));
            carManager.AddCar(new Car(2, "Volkswagen", "Passat", 2011));
            carManager.AddCar(new Car(3, "Kia", "Rio", 2015));


            carManager.ListCars();

            carManager.RemoveCar(3);

            carManager.ListCars();

            carManager.FindCar(2);
        }
    }
}
