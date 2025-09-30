using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var payment = new CreditCardPayment();
            var invoice = new PdfInvoice();
            var logger = new ConsoleLogger();
            var notification = new EmailNotification();

            var orderManager = new OrderManager(payment, invoice, logger, notification);
            orderManager.PlaceOrder("Doğan ALICI", 1500);
        }
    }
}
