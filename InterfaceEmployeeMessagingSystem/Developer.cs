using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEmployeeMessagingSystem
{
    public class Developer : IEmployee
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"[Developer] Mesajı : {message} yapmanız gerekiyor");
        }
    }
}
