using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapeDrawingSystem
{
    public class Circle : Shape  //Daire
    {
        public int Radius { get; set; }
        public override void Draw()
        {
            Console.WriteLine("---- DAİRE ÖZELLİKLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Adı : {Name}\n" +
                $"Yarıçapı : {Radius} Cm");
            Console.WriteLine("*********************************\n");
        }
    }
}
