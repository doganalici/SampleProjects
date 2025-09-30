using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public class OrderManager
    {
        //readonly yanlışlıkla atamayı engeller ve daha güvenli koda yol açar.
        //private dışarıdan doğrudan erişimi engeller — kapsülleme (encapsulation).
        private readonly IPayment _payment;
        private readonly IInvoice _invoice;
        private readonly ILogger _logger;
        private readonly INotification _notification;

        //Constructor — dependency injection
        public OrderManager(IPayment payment, IInvoice invoice, ILogger logger, INotification notification)
        {
            _payment = payment;
            _invoice = invoice;
            _logger = logger;
            _notification = notification;
        }

    
        public void PlaceOrder(string customer, decimal amount)
        {
            // 1) Ödeme işle
            _payment.Pay(amount);

            // 2) Fatura oluştur
            _invoice.Generate(customer, amount);

            // 3) Log kaydı
            _logger.Log("Sipariş işlendi");

            // 4) Bildirim gönder
            _notification.Send(customer, "Sipariş başarıyla alınmıştır");
        }

    }
}
