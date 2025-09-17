using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicleManagementSystem
{
    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("\t---- ARABA BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Markası : {Brand}\n" +
                $"Modeli : {Model}\n" +
                $"Yakıt Türü : {FuelType}\n" +
                $"Yılı : {Year}\n" +
                $"Yaşı : {DateTime.Now.Year - Year}\n" +
                $"Ücreti : {Price:N0} TL\n");

            Console.WriteLine("*************************************\n");
        }
    }
}
