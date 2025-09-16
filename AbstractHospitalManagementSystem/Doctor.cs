using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHospitalManagementSystem
{
    public class Doctor : HospitalMember
    {
        public string Specialization { get; set; } //uzmanlık alanı
        public int Salary { get; set; } //maaş
        public override void ShowInfo()
        {
            Console.WriteLine("\t ---- DOKTOR BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Adı : {FirstName}\n" +
                $"Soyadı : {LastName}\n" +
                $"Yaşı : {Age}\n" +
                $"Departmanı : {Department}\n" +
                $"Uzmanlık Alanı : {Specialization}\n" +
                $"Maaşı : {Salary} TL");
            Console.WriteLine("********************************************\n");
        }
    }
}
