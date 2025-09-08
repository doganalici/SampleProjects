using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPaymentSystem
{
    public class CashPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("\t **** NAKİT ÖDEME ****\n");
            Console.WriteLine($"Nakit olarak {Amount:N0} TL ödeme yapıldı.\n" +
                $"İşlem numarası : {TransactionId}\n"+
                $"Ödeme Tarihi : {PaymentDate}");
            Console.WriteLine("----------------------------------------\n");
        }
    }
}
