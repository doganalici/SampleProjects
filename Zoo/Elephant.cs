using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Elephant : Animal
    {
        public int Weight { get; set; }
        public string Country { get; set; }

        public void ElephantInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Ağırlık : {Weight}");
            Console.WriteLine($"Ülke : {Country}");
            Console.WriteLine("************************");
        }
    }
}
