using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTrackingSystem
{
    public class CarManager
    {
        private List<Car> cars = new List<Car>();
        public CarManager()
        {

        }
        public void AddCar(Car car)
        {
            Car existing = cars.FirstOrDefault(c => c.Id == car.Id);
            if (existing != null)
            {
                Console.WriteLine("Bu ID'ye sahip bir araç zaten var. Eklenemedi !");
                return;
            }
            cars.Add(car);
            Console.WriteLine($"{car.Brand} {car.Model} araç başarıyla eklendi.");
        }

        public void ListCars()
        {
            if (cars.Count > 0)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("Listedeki araç bilgileri : \n");
                foreach (var car in cars)
                {
                    Console.WriteLine($"Araç;\nId : {car.Id}\nMarka : {car.Brand}\nModel : {car.Model}\nYıl : {car.Year}");
                    Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*\n");
                }
            }
            else
            {
                Console.WriteLine("Listede hiçbir araç bulunmuyor !!!");
            }
        }

        public void RemoveCar(int id)
        {
            Car carToRemove = cars.FirstOrDefault(c => c.Id == id);
            if (carToRemove == null)
            {
                Console.WriteLine("Bu Id numarasıyla herhangi bir araç bulunamadı !!!");
                return;
            }

            cars.Remove(carToRemove);
            Console.WriteLine($"{carToRemove.Brand} {carToRemove.Model} Araç başarıyla silinmiştir");
        }

        public void FindCar(int id)
        {
            Car carToFind = cars.FirstOrDefault(c => c.Id == id);
            if (carToFind == null)
            {
                Console.WriteLine("Bu Id numarasıyla herhangi bir araç bulunamadı !!!");
                return;
            }
            Console.WriteLine($"Aranan aracın bilgileri;\nId : {carToFind.Id}\nMarka : {carToFind.Brand}\nModel : {carToFind.Model}\nYıl : {carToFind.Year}");
        }
    }
}