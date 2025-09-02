using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion();
            lion1.Id = 1;
            lion1.Name = "Aslan Kral";
            lion1.Age = 8;
            lion1.Origin = "Afrika";
            lion1.Food = "Etçil";

            Lion lion2 = new Lion();
            lion2.Id = 2;
            lion2.Name = "Simba";
            lion2.Age = 5;
            lion2.Origin = "Kenya";
            lion2.Food = "Etçil";


            Elephant elephant1 = new Elephant();
            elephant1.Id = 3;
            elephant1.Name = "Dumbo";
            elephant1.Age = 12;
            elephant1.Weight = 5400;
            elephant1.Country = "Hindistan";

            Elephant elephant2 = new Elephant();
            elephant2.Id = 4;
            elephant2.Name = "Jumbo";
            elephant2.Age = 20;
            elephant2.Weight = 6000;
            elephant2.Country = "Tayland";

            Console.WriteLine("\n\t ----- ASLANLAR -----\n");
            var lions = new Lion[] { lion1, lion2 };
            foreach (Lion lion in lions)
            {
                lion.LionInfo();
            }

            Console.WriteLine("\n\t ----- FİLLER -----\n");
            var elephants = new Elephant[] { elephant1, elephant2 };
            foreach (Elephant elephant in elephants)
            {
                elephant.ElephantInfo();
            }
        }
    }
}
