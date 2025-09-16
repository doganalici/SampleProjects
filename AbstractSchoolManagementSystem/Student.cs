using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSchoolManagementSystem
{
    public class Student : SchoolMember
    {
        public int Grade { get; set; } //Sınıf seviyesi
        public double GPA { get; set; } //Ortalama
        public override void ShowInfo()
        {
            Console.WriteLine("\t---- ÖĞRENCİ BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"İsim Soyisimi : {FirstName} {LastName}\n" +
                $"Yaşı : {Age}\n" +
                $"Görevi : {Role}\n" +
                $"Sınıfı : {Grade}\n" +
                $"Ortalaması : {GPA}");
            Console.WriteLine("***************************************\n");

        }
    }
}
