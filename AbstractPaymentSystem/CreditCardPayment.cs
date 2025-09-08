using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPaymentSystem
{

    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public override void ProcessPayment()
        {
            string hiddenCard = "**** **** **** " + CardNumber.Substring(CardNumber.Length - 4);
            Console.WriteLine("\t **** KREDİ KARTIYLA ÖDEME ****\n");
            Console.WriteLine($"Kredi kartıyla {Amount:N0} TL ödeme yapıldı.\n" +
                $"Kart Numarası : {hiddenCard}\n" +
                $"İşlem numarası : {TransactionId}\n" +
                $"Ödeme Tarihi : {PaymentDate}");
            Console.WriteLine("----------------------------------------\n");
        }
    }
}
