using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibraryManagementSystem
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("  ---- DERGİ BİLGİLERİ ----\n");
            Console.WriteLine($"Id: {Id}\n" +
                $"Adı : {Name}\n" +
                $"Yazarı : {Author}\n" +
                $"Türü : {Type}\n" +
                $"Sayı No : {IssueNumber}\n" +
                $"Tutarı : {Price} TL");
            
        }
    }
}
