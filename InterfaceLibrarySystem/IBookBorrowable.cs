using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrarySystem
{
    public interface IBookBorrowable
    {
        void Borrow(string member);
        void Return(string member);
    }
}
