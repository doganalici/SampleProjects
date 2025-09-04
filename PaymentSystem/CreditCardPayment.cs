using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class CreditCardPayment:Payment
    {
        public string CardNumber { get; set; }

        public override void Pay()
        {
            Console.WriteLine($"Kredi kartı ile {Amount} TL ödeme yapıldı\nKart : {CardNumber}");
        }
    }
}
