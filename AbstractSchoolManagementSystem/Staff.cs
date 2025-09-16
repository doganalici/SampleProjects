using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractSchoolManagementSystem
{
    public class Staff : SchoolMember
    {
        public string Position { get; set; } //Görev; memur,güvenlik vb.
        public string Shift { get; set; } //Vardiya
        public override void ShowInfo()
        {
            Console.WriteLine("\t---- PERSONEL BİLGİLERİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"İsim Soyisimi : {FirstName} {LastName}\n" +
                $"Yaşı : {Age}\n" +
                $"Görevi : {Role}\n" +
                $"Pozisyonu : {Position}\n" +
                $"Vardiyası : {Shift}");
            Console.WriteLine("***************************************\n");
        }
    }
}
