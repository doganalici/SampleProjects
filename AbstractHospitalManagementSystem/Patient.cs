using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHospitalManagementSystem
{
    public class Patient : HospitalMember
    {
        public string Disease { get; set; } //hastalık bilgisi
        public int TreatmentCost { get; set; } //tedavi ücreti
        public override void ShowInfo()
        {
            Console.WriteLine("\t ---- HASTA BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"Adı : {FirstName}\n" +
                $"Soyadı : {LastName}\n" +
                $"Yaşı : {Age}\n" +
                $"Departmanı : {Department}\n" +
                $"Hastalık Bilgisi : {Disease}\n" +
                $"Tedavi Ücreti : {TreatmentCost} TL");
            Console.WriteLine("********************************************\n");
        }
    }
}
