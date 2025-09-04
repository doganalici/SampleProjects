using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment cardPayment1 = new CreditCardPayment()
            {
                Id = 1,
                Amount = 250.50,
                CardNumber = "1234-5678-9012-3456"
            };

            Payment cardPayment2 = new CreditCardPayment()
            {
                Id = 2,
                Amount = 500,
                CardNumber = "9876-5432-1098-7654"
            };

            Payment paypalPayment1 = new PayPalPayment()
            {
                Id = 3,
                Amount = 100,
                Email = "user1@example.com"
            };

            Payment paypalPayment2 = new PayPalPayment()
            {
                Id = 4,
                Amount = 300,
                Email = "user2@example.com"
            };

            Payment bankTransferPayment1 = new BankTransferPayment()
            {
                Id = 5,
                Amount = 850,
                AccountNumber = "TR00 1234 5678 9012"
            };

            Payment bankTransferPayment2 = new BankTransferPayment()
            {
                Id = 6,
                Amount = 550.89,
                AccountNumber = "TR98 7654 3210 9012"
            };


            List<Payment> payments = new List<Payment>() { cardPayment1, cardPayment2, paypalPayment1, paypalPayment2, bankTransferPayment1, bankTransferPayment2 };
            Console.WriteLine("\t ----- ÖDEMELER ----- \n");
            foreach (Payment payment in payments)
            {
                payment.Pay();
                Console.WriteLine();
            }

        }
    }
}
