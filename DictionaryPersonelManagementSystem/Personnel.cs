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

        public override string ToString()
        {
            return $"Id : {Id}\nAd Soyad : {FirstName} {LastName}\nDepartman : {Department}\nMaaş : {Salary}\nTelefon Numarası : {PhoneNumber}";
        }
    }
}
