using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSchoolManagementSystem
{
    public abstract class SchoolMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        public abstract void ShowInfo();
    }
}
