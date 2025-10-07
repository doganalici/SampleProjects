using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTicketSystem
{
    public interface ITicketService
    {
        void Purchase(string film, int seat, int salary);

        void UpdatePrice(string film,int newPrice);
    }
}
