using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicleManagementSystem
{
    public class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("\t---- KAMYON BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Markası : {Brand}\n" +
                $"Modeli : {Model}\n" +
                $"Taşıma Kapasitesi : {LoadCapacity} TON\n" +
                $"Yılı : {Year}\n" +
                $"Yaşı : {DateTime.Now.Year - Year}\n" +
                $"Ücreti : {Price:N0} TL\n");

            Console.WriteLine("*************************************\n");
        }
    }
}
