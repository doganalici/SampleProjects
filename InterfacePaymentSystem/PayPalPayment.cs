using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePaymentSystem
{
    public class PayPalPayment : IPayment
    {
        public string AccountNumber { get; set; }
        public decimal Price { get; set; }
        public void ProcessPayment()
        {
            Console.WriteLine($"{AccountNumber} numaralı Paypal hesabı ile {Price:N0} TL ödeme alınmıştır");
        }

        public void Refund()
        {
            Console.WriteLine($"{AccountNumber} numaralı Paypal hesabına {Price:N0} TL iade işlemi yapılmıştır");
        }
    }
}
