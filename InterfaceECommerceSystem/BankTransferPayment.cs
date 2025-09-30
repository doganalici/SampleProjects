using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public class BankTransferPayment : IPayment
    {
        public void Pay(decimal pay)
        {
            Console.WriteLine($"Havale ile {pay:N0} TL tutarında ödeme yapılmıştır");
        }
    }
}
