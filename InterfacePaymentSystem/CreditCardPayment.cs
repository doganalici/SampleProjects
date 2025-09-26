using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePaymentSystem
{
    public class CreditCardPayment : IPayment
    {
        public string CardNumber { get; set; }
        public decimal Price { get; set; }
        public void ProcessPayment()
        {
            Console.WriteLine($"{CardNumber} numaralı kart ile {Price:N0} TL ödeme alınmıştır");
        }

        public void Refund()
        {
            Console.WriteLine($"{CardNumber} numaralı karta {Price:N0} TL iade işlemi yapılmıştır");
        }
    }
}
