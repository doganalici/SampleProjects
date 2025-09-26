using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePaymentSystem
{
    public interface IPayment
    {
        decimal Price {  get; set; }
        void ProcessPayment(); //Ödemeyi işleyecek
        void Refund(); //İade işlemi yapacak

    }
}
