using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    internal class PdfInvoice : IInvoice
    {
        public void Generate(string customer, decimal amount)
        {
            Console.WriteLine($"PDF olarak {customer} adlı kişiye {amount:N0} TL tutarında fatura kesilmiştir");
        }
    }
}
