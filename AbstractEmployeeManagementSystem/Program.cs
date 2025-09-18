using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee manager1 = new Manager()
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Age = 45,
                Department = "Yönetim",
                Salary = 40000,
                TeamSize = 10
            };

            Employee manager2 = new Manager()
            {
                Id = 2,
                FirstName = "Selin",
                LastName = "Demir",
                Age = 38,
                Department = "İnsan Kaynakları",
                Salary = 35000,
                TeamSize = 6
            };

            Employee developer1 = new Developer()
            {
                Id = 3,
                FirstName = "Mehmet",
                LastName = "Kara",
                Age = 28,
                Department = "Yazılım",
                Salary = 25000,
                ProgrammingLanguage = "C#"
            };

            Employee developer2 = new Developer()
            {
                Id = 4,
                FirstName = "Zeynep",
                LastName = "Şahin",
                Age = 26,
                Department = "Yazılım",
                Salary = 24000,
                ProgrammingLanguage = "Java"
            };

            Employee intern1 = new Intern()
            {
                Id = 5,
                FirstName = "Ali",
                LastName = "Çelik",
                Age = 21,
                Department = "Yazılım",
                Salary = 5000,
                InternshipDuration = 6
            };

            Employee intern2 = new Intern()
            {
                Id = 6,
                FirstName = "Ayşe",
                LastName = "Kaya",
                Age = 22,
                Department = "Pazarlama",
                Salary = 4500,
                InternshipDuration = 4
            };

            List<Employee> employees = new List<Employee>()
            {
                manager1,manager2,developer1,developer2,intern1,intern2
            };

            foreach (Employee employee in employees)
            {
                employee.ShowInfo();
            }
        }
    }
}
