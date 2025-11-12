using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPersonelManagementSystem
{
    public class Personnel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }

        public Personnel(int id, string firstName, string lastName, string department, decimal salary, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = salary;
            PhoneNumber = phoneNumber;
        }
        public Personnel(string firstName)
        {
            FirstName = firstName;
        }

        public override string ToString()
        {
            return $"Id : {Id}\nAd Soyad : {FirstName} {LastName}\nDepartman : {Department}\nMaaş : {Salary}\nTelefon Numarası : {PhoneNumber}";
        }

        public void UpdateFirstName(string newName)
        {
            FirstName = newName ;
            Console.WriteLine("İsim bilgisi güncellendi");
        }
        public void UpdateLastName(string newLastName)
        {
            LastName = newLastName ;
            Console.WriteLine("Soyisim bilgisi güncellendi");
        }
        public void UpdateDepartment(string newDepartment)
        {
            Department = newDepartment;
            Console.WriteLine("Departman bilgisi güncellendi");
        }
        public void UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
            Console.WriteLine("Maaş bilgisi güncellendi");
        }
        public void UpdatePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
            Console.WriteLine("Telefon numarası bilgisi güncellendi");
        }
    }
}
