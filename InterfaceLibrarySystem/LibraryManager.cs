using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrarySystem
{
    public class LibraryManager
    {
        private readonly IBookBorrowable _book;
        private readonly INotifier _notifier;

        public LibraryManager(IBookBorrowable book, INotifier notifier)
        {
            _book = book;
            _notifier = notifier;
        }

        public void BorrowBook(string member)
        {
            _book.Borrow(member);
            _notifier.Notify(member,"Kitabı başarıyla ödünç aldınız");
        }

        public void ReturnBook(string member)
        {
            _book.Return(member);
            _notifier.Notify(member, "Kitabı başarıyla iade ettiniz");
        }
    }
}
