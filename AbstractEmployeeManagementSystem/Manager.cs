using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeManagementSystem
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("\t ---- YÖNETİCİ LİSTESİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"İsim : {FirstName}\n" +
                $"Soyisim : {LastName}\n" +
                $"Yaş : {Age}\n" +
                $"Departman : {Department}\n" +
                $"Yönetilen Ekipdeki Personel Sayısı : {TeamSize}\n" +
                $"Maaş : {Salary:N0} TL");
            Console.WriteLine("***********************************************\n");
        }
    }
}
