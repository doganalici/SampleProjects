using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person
    {
        public string Branch { get; set; }
        public double Salary { get; set; }

        public void TeacherInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Alanı : {Branch}");
            Console.WriteLine($"Maaşı : {Salary}");
            Console.WriteLine("\n******************************\n");
        }
    }
}
