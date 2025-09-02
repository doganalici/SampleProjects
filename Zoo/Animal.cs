using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowBaseInfo()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Adı : {Name}");
            Console.WriteLine($"Yaşı : {Age}");
        }
    }
}
