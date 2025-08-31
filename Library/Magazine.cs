using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Magazine:LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Publisher { get; set; }

        public void MagazineInfo()
        {
            ShowBaseInfo();
            Console.WriteLine($"Dergi Numarası : {IssueNumber}");
            Console.WriteLine($"Yayıncı : {Publisher}");
            Console.WriteLine("\n****************************************\n");

        }
    }
}
