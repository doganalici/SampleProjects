using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTicketSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var onlineService = new Online();
            var online = new TicketManager(onlineService);
            var boxOfficeService = new BoxOffice();
            var boxOffice = new TicketManager(boxOfficeService);

            online.Purchase("Prestij", 55, 1250);
            online.Purchase("Leon: Sevginin Gücü", 26, 850);
            online.Purchase("Piyanist", 66, 1000);
            online.Purchase("Gladyatör", 94, 1150);

            boxOffice.Purchase("Akıl Oyunları", 128, 750);
            boxOffice.Purchase("2012", 28, 550);
            boxOffice.Purchase("Altıncı His", 70, 800);
            boxOffice.Purchase("Schindler'in Listesi", 110, 650);


            Console.WriteLine("\n\t ---- GÜNCELLEME ----");
            online.UpdatePrice("Leon: Sevginin Gücü", 800);
            online.UpdatePrice("Gladyatör", 950);
            boxOffice.UpdatePrice("Altıncı His", 600);
            Console.WriteLine("-------------------------------------------------------------------");

            online.ShowAllReport();
            boxOffice.ShowAllReport();

            online.ShowTotalRevenue("Online satış");
            boxOffice.ShowTotalRevenue("Gişe satışı");

        }
    }
}
