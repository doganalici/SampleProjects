using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEmployeeMessagingSystem
{
    public class Manager : IEmployee
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"[Manager] Mesajı : {message} yapmanız gerekiyor");
        }
    }
}
