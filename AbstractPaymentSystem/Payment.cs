using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPaymentSystem
{
    public abstract class Payment
    {
        public double Amount { get; set; } //Ücret
        public DateTime PaymentDate { get; set; } //Ödme tarihi
        public string TransactionId { get; set; } //işlem numarası
        public abstract void ProcessPayment();
    }
}
