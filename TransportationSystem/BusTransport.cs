using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationSystem
{
    public class BusTransport : Transport
    {
        public int SeatNumber { get; set; }
        public override void Travel()
        {
            Console.WriteLine("\t ------ OTOBÜS YOLCULUĞU ------ \n");
            Console.WriteLine($"Otobüs ile {Destination} konumuna varıldı.\n" +
                $"Koltuk no : {SeatNumber}\n" +
                $"Ücret : {Price:N0} TL\n" +
                $"Yolculuk tarihi : {TravelDate:dd.MM.yyyy} ");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
