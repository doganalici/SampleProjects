using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapeDrawingSystem
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Draw();
    }
}
