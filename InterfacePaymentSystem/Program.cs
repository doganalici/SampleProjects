using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransactionManager manager = new TransactionManager();
            manager.AddPayment(new CreditCardPayment { CardNumber = "1234 5678 9012 3456", Price = 1500 });
            manager.AddPayment(new CreditCardPayment { CardNumber = "9876 5432 0123 8564", Price = 2250 });
            manager.AddPayment(new PayPalPayment { AccountNumber = "paypal-1", Price = 300 });
            manager.AddPayment(new PayPalPayment { AccountNumber = "paypal-2", Price = 750 });
            manager.AddPayment(new BankTransferPayment { IBAN = "TR00 1234 5678 9012 3456 0000", Price = 500 });
            manager.AddPayment(new BankTransferPayment { IBAN = "TR64 6518 6494 9818 6543 1234", Price = 500 });

            Console.WriteLine("Ödeme işlemleri başlatılıyor...");
            Console.WriteLine("**********************************\n");
            manager.ProcessAllPayments();


            Console.WriteLine("\nİade işlemleri başlatılıyor...");
            Console.WriteLine("**********************************\n");
            manager.RefundAllPayments();

            Console.WriteLine("\n**********************************\n");
            Console.WriteLine($"Toplam ödeme miktarı : {manager.GetTotalPayments():N0} TL");

        }
    }
}
