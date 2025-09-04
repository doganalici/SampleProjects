using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class BankTransferPayment:Payment
    {
        public string AccountNumber { get; set; }

        public override void Pay()
        {
            Console.WriteLine($"Banka transferi ile {Amount} TL ödeme yapıldı.\nHesap Numarası : {AccountNumber}");
        }
    }
}
