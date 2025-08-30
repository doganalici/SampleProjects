using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ShowBaseInfo()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Adı : {FirstName}");
            Console.WriteLine($"Soyadı : {LastName}");
        }
    }
}
