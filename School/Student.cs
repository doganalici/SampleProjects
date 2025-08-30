using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        public string Classroom { get; set; }
        public double Grade { get; set; }

        public void StudentInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Sınıfı : {Classroom}");
            Console.WriteLine($"Ortalama : {Grade}");
            Console.WriteLine("\n******************************\n");
        }
    }
}
