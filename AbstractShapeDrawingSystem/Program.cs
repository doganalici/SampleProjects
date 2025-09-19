using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapeDrawingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle1 = new Circle()
            {
                Id = 1,
                Name = "Daire",
                Radius = 5
            };

            Shape circle2 = new Circle()
            {
                Id = 2,
                Name = "Daire",
                Radius = 10
            };

            Shape rectangle1 = new Rectangle()
            {
                Id = 3,
                Name = "Dikdörtgen",
                Width = 4,
                Height = 6
            };


            Shape rectangle2 = new Rectangle()
            {
                Id = 4,
                Name = "Dikdörtgen",
                Width = 8,
                Height = 12
            };

            Shape triangle1 = new Triangle()
            {
                Id = 5,
                Name = "Üçgen",
                Base = 6,
                Height = 4
            };


            Shape triangle2 = new Triangle()
            {
                Id = 6,
                Name = "Üçgen",
                Base = 10,
                Height = 8
            };

            List<Shape> shapeList = new List<Shape>() { circle1, circle2, rectangle1, rectangle2, triangle1, triangle2 };

            foreach (Shape shape in shapeList)
            {
                shape.Draw();
            }
        }
    }
}
