using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceECommerceSystem
{
    public interface IInvoice //Fatra
    {
        void Generate(string customer,decimal amount);
    }
}
