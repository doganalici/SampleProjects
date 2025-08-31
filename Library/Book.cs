using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book:LibraryItem
    {
        public int PageCount { get; set; }
        public string Genre { get; set; }

        public void BookInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Sayfa Sayısı : {PageCount}");
            Console.WriteLine($"Tür : {Genre}");
            Console.WriteLine("\n****************************************\n");
        }
    }
}
