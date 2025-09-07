using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationSystem
{
    public class ShipTransport : Transport
    {
        public string CabinNumber { get; set; }
        public override void Travel()
        {
            Console.WriteLine("\t ------ GEMİ YOLCULUĞU ------ \n");
            Console.WriteLine($"Gemi ile {Destination} konumuna varıldı.\n" +
                $"Kabin no : {CabinNumber}\n" +
                $"Ücret : {Price:N0} TL\n" +
                $"Yolculuk tarihi : {TravelDate:dd.MM.yyyy}");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
