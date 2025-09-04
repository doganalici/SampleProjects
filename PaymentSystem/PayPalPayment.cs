using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class PayPalPayment:Payment
    {
        public string Email { get; set; }

        public override void Pay()
        {
            Console.WriteLine($"PayPal ile {Amount} TL ödeme yapıldı.\nEmail : {Email}");
        }
    }
}
