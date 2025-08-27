using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTrackingSystem
{
    public class Student
    {
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"Öğrencinin numarası : {Number}");
            Console.WriteLine($"Öğrencinin Adı : {FirstName}");
            Console.WriteLine($"Öğrencinin Soyadı : {LastName}");
            Console.WriteLine($"Öğrencinin Yaşı : {Age}");
            if (Grade < 0 || Grade > 100)
            {
                Console.WriteLine("Hatalı not girişi!");
            }
            else
            {
                Console.WriteLine($"Öğrencinin Notu : {Grade}");

            }
            Console.WriteLine("\n***************************************\n");
        }

        public void UpdateGrade(double newGrade)
        {
            Console.WriteLine($"{FirstName} {LastName} adlı öğreninin notu güncellendi!");
            Grade = newGrade;
        }
    }

}
