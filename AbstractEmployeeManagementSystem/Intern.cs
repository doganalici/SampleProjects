using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeManagementSystem
{
    public class Intern : Employee
    {
        public int InternshipDuration { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("\t ---- STAJYER LİSTESİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"İsim : {FirstName}\n" +
                $"Soyisim : {LastName}\n" +
                $"Yaş : {Age}\n" +
                $"Departman : {Department}\n" +
                $"Staj Süresi : {InternshipDuration} AY\n" +
                $"Maaş : {Salary:N0} TL");
            Console.WriteLine("***********************************************\n");
        }
    }
}
