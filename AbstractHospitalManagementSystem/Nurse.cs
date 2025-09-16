using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHospitalManagementSystem
{
    public class Nurse : HospitalMember
    {
        public int ExperienceYear { get; set; } //deneyim yılı
        public int Salary { get; set; } //maaş
        public override void ShowInfo()
        {
            Console.WriteLine("\t ---- HEMŞİRE BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Adı : {FirstName}\n" +
                $"Soyadı : {LastName}\n" +
                $"Yaşı : {Age}\n" +
                $"Departmanı : {Department}\n" +
                $"Deneyim yılı : {ExperienceYear}\n" +
                $"Maaşı : {Salary} TL");
            Console.WriteLine("********************************************\n");
        }
    }
}
