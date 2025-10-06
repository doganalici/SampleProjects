using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEmployeeMessagingSystem
{
    public class Designer : IEmployee
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"[Designer] Mesajı : {message} yapmanız gerekiyor");
        }
    }
}
