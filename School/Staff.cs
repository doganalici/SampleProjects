using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Staff : Person
    {
        public string Position { get; set; }
        public int WorkHours { get; set; }

        public void StaffInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Pozisyon : {Position}");
            Console.WriteLine($"Çalışma Saati : {WorkHours}");
            Console.WriteLine("\n******************************\n");

        }
    }
}
