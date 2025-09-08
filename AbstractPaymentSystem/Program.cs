using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment creditCard1 = new CreditCardPayment()
            {
                Amount = 150,
                CardNumber = "1234 5678 9012 3456",
                TransactionId = "TXN001",
                PaymentDate=DateTime.Now
            };

            Payment creditCard2 = new CreditCardPayment()
            {
                Amount = 1300,
                CardNumber = "9876 5432 1098 7654",
                TransactionId = "TXN002",
                PaymentDate = DateTime.Now.AddMinutes(-30)
            };

            Payment cash1 = new CashPayment()
            {
                Amount = 250,
                TransactionId = "TXN003",
                PaymentDate = DateTime.Now.AddHours(-1)
            };

            Payment cash2 = new CashPayment()
            {
                Amount = 750,
                TransactionId = "TXN004",
                PaymentDate = DateTime.Now.AddHours(-1)
            };

            Payment bankTransfer1 = new BankTransferPayment()
            {
                Amount = 2500,
                IBAN = "TR98 7654 3210 9876 5432 1098 76",
                TransactionId = "TXN005",
                PaymentDate = DateTime.Now
            };

            Payment bankTransfer2 = new BankTransferPayment()
            {
                Amount = 4500,
                IBAN = "TR12 3456 7890 1234 5678 9012 34",
                TransactionId = "TXN006",
                PaymentDate = DateTime.Now.AddDays(-2)
            };

            List<Payment> paymentList = new List<Payment>() { creditCard1, creditCard2, cash1, cash2, bankTransfer1, bankTransfer2 };
            foreach (Payment payment in paymentList)
            {
                payment.ProcessPayment();
            }
        }
    }
}
