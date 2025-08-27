using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTrackingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Number = 1;
            student1.FirstName = "Doğan";
            student1.LastName = "Alıcı";
            student1.Age = 26;
            student1.Grade = 60;

            Student student2 = new Student();
            student2.Number = 2;
            student2.FirstName = "Sümeyye";
            student2.LastName = "Alıcı";
            student2.Age = 27;
            student2.Grade = 70;

            Student student3 = new Student();
            student3.Number = 3;
            student3.FirstName = "Test1";
            student3.LastName = "Test2";
            student3.Age = 28;
            student3.Grade = 80;

            var students = new Student[] { student1, student2, student3 };
            foreach (var student in students)
            {
                student.StudentInfo();
            }
            student2.UpdateGrade(90);
            student2.StudentInfo();
        }
    }
}
