using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHospitalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HospitalMember doctor1 = new Doctor()
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Age = 45,
                Department = "Kardiyoloji",
                Specialization = "Kalp Cerrahisi",
                Salary = 30000
            };

            HospitalMember doctor2 = new Doctor()
            {
                Id = 2,
                FirstName = "Ayşe",
                LastName = "Demir",
                Age = 38,
                Department = "Nöroloji",
                Specialization = "Beyin Cerrahisi",
                Salary = 28000
            };


            HospitalMember nurse1 = new Nurse()
            {
                Id = 3,
                FirstName = "Mehmet",
                LastName = "Kaya",
                Age = 30,
                Department = "Acil Servis",
                ExperienceYear = 5,
                Salary = 15000
            };


            HospitalMember nurse2 = new Nurse()
            {
                Id = 4,
                FirstName = "Fatma",
                LastName = "Çelik",
                Age = 28,
                Department = "Yoğun Bakım",
                ExperienceYear = 3,
                Salary = 14000
            };

            HospitalMember patient1 = new Patient()
            {
                Id = 5,
                FirstName = "Ali",
                LastName = "Can",
                Age = 50,
                Department = "Kardiyoloji",
                Disease = "Kalp Yetmezliği",
                TreatmentCost = 12000
            };

            HospitalMember patient2 = new Patient()
            {
                Id = 6,
                FirstName = "Zeynep",
                LastName = "Şahin",
                Age = 22,
                Department = "Ortopedi",
                Disease = "Kırık Tedavisi",
                TreatmentCost = 8000
            };

            List<HospitalMember> hospitalMembers = new List<HospitalMember>() { doctor1, doctor2, nurse1, nurse2, patient1, patient2, };

            foreach (var hospitalMember in hospitalMembers)
            {
                hospitalMember.ShowInfo();
            }
        }
    }
}
