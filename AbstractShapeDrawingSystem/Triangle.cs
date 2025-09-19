using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapeDrawingSystem
{
    public class Triangle : Shape //Üçgen
    {
        public int Base { get; set; }
        public int Height { get; set; }
        public override void Draw()
        {
            Console.WriteLine("---- ÜÇGEN ÖZELLİKLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Adı : {Name}\n" +
                $"Tabanı : {Base} Cm\n" +
                $"Yüksekliği : {Height} Cm");
            Console.WriteLine("*********************************\n");
        }
    }
}
