using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Id = 1;
            student1.FirstName = "Ahmet";
            student1.LastName = "Kasım";
            student1.Classroom = "10-C";
            student1.Grade = 75.50;

            Student student2 = new Student();
            student2.Id = 2;
            student2.FirstName = "Ali";
            student2.LastName = "Yaman";
            student2.Classroom = "12-A";
            student2.Grade = 82;
            Console.WriteLine("\t***** ÖĞRENCİ LİSTESİ *****\n");

            var students = new Student[] { student1, student2 };
            foreach (var student in students)
            {
                student.StudentInfo();
            }

            Teacher teacher1 = new Teacher();
            teacher1.Id = 3;
            teacher1.FirstName = "Kemal";
            teacher1.LastName = "Yoldaş";
            teacher1.Branch = "Matematik";
            teacher1.Salary = 42500;

            Teacher teacher2 = new Teacher();
            teacher2.Id = 4;
            teacher2.FirstName = "Yaşar";
            teacher2.LastName = "Kınık";
            teacher2.Branch = "Türkçe";
            teacher2.Salary = 48950;

            Console.WriteLine("\t***** ÖĞRETMEN LİSTESİ *****\n");

            var teachers = new Teacher[] { teacher1, teacher2 };
            foreach (var teacher in teachers)
            {
                teacher.TeacherInfo();
            }

            Staff staff1 = new Staff();
            staff1.Id = 5;
            staff1.FirstName = "Mustafa";
            staff1.LastName = "Akıncı";
            staff1.Position = "Hizmetli";
            staff1.WorkHours = 42;

            Staff staff2 = new Staff();
            staff2.Id = 6;
            staff2.FirstName = "Hamdi";
            staff2.LastName = "Kandemir";
            staff2.Position = "Memur";
            staff2.WorkHours = 36;


            Console.WriteLine("\t***** ÇALIŞAN LİSTESİ *****\n");

            var staffs = new Staff[] { staff1, staff2 };
            foreach (var staff in staffs)
            {
                staff.StaffInfo();
            }

        }
    }
}
