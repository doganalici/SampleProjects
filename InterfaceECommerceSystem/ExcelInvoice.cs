using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public class ExcelInvoice : IInvoice
    {
        public void Generate(string customer, decimal amount)
        {
            Console.WriteLine($"Excel olarak {customer} adlı kişiye {amount:N0} TL tutarında fatura kesilmiştir");
        }
    }
}
