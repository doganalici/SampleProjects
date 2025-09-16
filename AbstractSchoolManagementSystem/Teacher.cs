using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSchoolManagementSystem
{
    public class Teacher : SchoolMember
    {
        public string Subject { get; set; } //Branş
        public decimal Salary { get; set; } //Maaş
        public override void ShowInfo()
        {
            Console.WriteLine("\t---- ÖĞRETMEN BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"İsim Soyisimi : {FirstName} {LastName}\n" +
                $"Yaşı : {Age}\n" +
                $"Görevi : {Role}\n" +
                $"Branşı : {Subject}\n" +
                $"Maaşı : {Salary:N0} TL");
            Console.WriteLine("***************************************\n");
        }
    }
}
