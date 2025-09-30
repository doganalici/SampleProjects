using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(decimal pay)
        {
            Console.WriteLine($"Kredi kartı ile {pay:N0} TL ödeme yapılmıştır");
        }
    }
}
