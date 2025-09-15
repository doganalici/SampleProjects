using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibraryManagementSystem
{
    public class EBook : LibraryItem
    {
        public int FileSizeMB { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("  ---- E-KİTAP BİLGİLERİ ----\n");
            Console.WriteLine($"Id: {Id}\n" +
                $"Adı : {Name}\n" +
                $"Yazarı : {Author}\n" +
                $"Türü : {Type}\n" +
                $"Dosya Boyutu : {FileSizeMB} MB\n" +
                $"Tutarı : {Price} TL");
           
        }
    }
}
