using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePaymentSystem
{
    public class TransactionManager
    {
        private List<IPayment> payments = new List<IPayment>();
        public void AddPayment(IPayment payment)
        {
            payments.Add(payment);
        }

        public void ProcessAllPayments()
        {
            foreach (IPayment payment in payments)
            {
                payment.ProcessPayment();
                Console.WriteLine("----");
            }

        }

        public void RefundAllPayments()
        {
            foreach (IPayment payment in payments)
            {
                payment.Refund();
                Console.WriteLine("----");
            }
        }

        public decimal GetTotalPayments()
        {
            decimal total = 0;
            foreach (IPayment payment in payments)
            {
                total += payment.Price;
            }
            return total;
        }
    }
}
