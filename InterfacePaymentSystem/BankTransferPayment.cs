using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePaymentSystem
{
    public class BankTransferPayment : IPayment
    {
        public string IBAN { get; set; }
        public decimal Price { get; set; }
        public void ProcessPayment()
        {
            Console.WriteLine($"{IBAN} numaralı banka hesabından {Price:N0} TL ödeme alınmıştır");

        }

        public void Refund()
        {
            Console.WriteLine($"{IBAN} numaralı banka hesabına {Price:N0} TL iade işlemi yapılmıştır");
        }
    }
}
