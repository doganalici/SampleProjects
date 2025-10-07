using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTicketSystem
{
    public class Ticket
    {
        public string Film { get; set; }
        public int Seat { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; } // satın alma zamanı
    }
}