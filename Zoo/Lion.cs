using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Lion : Animal
    {
        public string Origin { get; set; }
        public string Food { get; set; }

        public void LionInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Nereden geldi? : {Origin}");
            Console.WriteLine($"Beslenme Tipi : {Food}");
            Console.WriteLine("************************");
        }
    }
}
