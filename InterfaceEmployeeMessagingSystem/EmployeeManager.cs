using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEmployeeMessagingSystem
{
    public class EmployeeManager
    {
        private readonly IEmployee _employee;

        public EmployeeManager(IEmployee employee)
        {
            _employee = employee;
        }
        public void Notify(string message)
        {
            _employee.SendMessage(message);
        }
    }
}
