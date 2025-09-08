using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPaymentSystem
{
    public class BankTransferPayment : Payment
    {
        public string IBAN { get; set; }
        public override void ProcessPayment()
        {
            Console.WriteLine("\t **** HAVALE/EFT İLE ÖDEME ****\n");
            Console.WriteLine($"Havale/EFT ile {Amount:N0} TL ödeme yapıldı.\n" +
                $"IBAN : {IBAN}\n" +
                $"İşlem numarası : {TransactionId}\n" +
                $"Ödeme Tarihi : {PaymentDate}");
            Console.WriteLine("----------------------------------------\n");
        }
    }
}
