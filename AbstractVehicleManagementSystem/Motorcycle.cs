using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicleManagementSystem
{
    public class Motorcycle : Vehicle
    {
        public string EngineCapacity { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("\t---- MOTOR BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Markası : {Brand}\n" +
                $"Modeli : {Model}\n" +
                $"Motor Gücü : {EngineCapacity}\n" +
                $"Yılı : {Year}\n" +
                $"Yaşı : {DateTime.Now.Year - Year}\n" +
                $"Ücreti : {Price:N0} TL\n");

            Console.WriteLine("*************************************\n");
        }
    }
}
