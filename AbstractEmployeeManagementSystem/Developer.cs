using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeManagementSystem
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("\t ---- YAZILIMCI LİSTESİ ----\n");
            Console.WriteLine($"Id : {Id}\n" +
                $"İsim : {FirstName}\n" +
                $"Soyisim : {LastName}\n" +
                $"Yaş : {Age}\n" +
                $"Departman : {Department}\n" +
                $"Programlama Dili : {ProgrammingLanguage}\n" +
                $"Maaş : {Salary:N0} TL");
            Console.WriteLine("***********************************************\n");
        }
    }
}
