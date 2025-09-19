using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapeDrawingSystem
{
    public class Rectangle : Shape //Dikdörtgen
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override void Draw()
        {
            Console.WriteLine("---- DİKDÖRTGEN ÖZELLİKLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Adı : {Name}\n" +
                $"Genişliği : {Width} Cm\n" +
                $"Yüksekliği : {Height} Cm");
            Console.WriteLine("*********************************\n");
        }
    }
}
