using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSchoolManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolMember student1 = new Student()
            {
                Id = 1,
                FirstName = "Elif",
                LastName = "Yılmaz",
                Age = 16,
                Role = "Öğrenci",
                Grade = 10,
                GPA = 85.5
            };

            SchoolMember student2 = new Student()
            {
                Id = 2,
                FirstName = "Emre",
                LastName = "Demir",
                Age = 17,
                Role = "Öğrenci",
                Grade = 11,
                GPA = 92.3
            };

            SchoolMember teacher1 = new Teacher()
            {
                Id = 3,
                FirstName = "Ahmet",
                LastName = "Kara",
                Age = 40,
                Role = "Öğretmen",
                Subject = "Matematik",
                Salary = 25000
            };

            SchoolMember teacher2 = new Teacher()
            {
                Id = 4,
                FirstName = "Fatma",
                LastName = "Çelik",
                Age = 35,
                Role = "Öğretmen",
                Subject = "Türkçe",
                Salary = 24000
            };

            SchoolMember staff1 = new Staff()
            {
                Id = 5,
                FirstName = "Mehmet",
                LastName = "Şahin",
                Age = 45,
                Role = "Personel",
                Position = "Memur",
                Shift = "Gündüz"
            };


            SchoolMember staff2 = new Staff()
            {
                Id = 6,
                FirstName = "Ayşe",
                LastName = "Aydın",
                Age = 38,
                Role = "Personel",
                Position = "Güvenlik",
                Shift = "Gece"
            };

            List<SchoolMember> schoolMembers = new List<SchoolMember>() { student1,student2,teacher1,teacher2,staff1, staff2 };
        
            foreach (SchoolMember schoolMember in schoolMembers)
            {
                schoolMember.ShowInfo();
            }
        }
    }
}
