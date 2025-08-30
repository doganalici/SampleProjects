using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            phone1.Id = 1;
            phone1.Brand = "Xiaomi";
            phone1.Model = "Redmi Note 12 Pro";
            phone1.Color = "Mavi";
            phone1.Year = 2022;
            phone1.Camera = "108 MP";

            Phone phone2 = new Phone();
            phone2.Id = 2;
            phone2.Brand = "Oppo";
            phone2.Model = "A72";
            phone2.Color = "Mor";
            phone2.Year = 2020;
            phone2.Camera = "50 MP";


            Computer computer1 = new Computer();
            computer1.Id = 3;
            computer1.Brand = "Msi";
            computer1.Model = "Katana";
            computer1.Color = "Siyah";
            computer1.Year = 2023;
            computer1.RAM = 16;
            computer1.RGBKeyboard = true;

            Computer computer2 = new Computer();
            computer2.Id = 4;
            computer2.Brand = "Casper";
            computer2.Model = "Nirvana";
            computer2.Color = "Gri";
            computer2.Year = 2016;
            computer2.RAM = 4;
            computer2.RGBKeyboard = false;

            var phones = new Phone[] { phone1, phone2 };
            foreach (var phone in phones)
            {
                phone.TurnOn();
                phone.TakePhoto();
                Console.WriteLine("\n******************************************************\n");
            }


            var computers = new Computer[] { computer1, computer2 };
            foreach (var computer in computers)
            {
                computer.TurnOn();
                Console.WriteLine("\n******************************************************\n");
            }

            phone1.TurnOff();
            Console.WriteLine("\n******************************************************\n");
            computer1.RunProgram("Visual Studio");
            Console.WriteLine("\n******************************************************\n");
        }
    }
}
