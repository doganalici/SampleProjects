using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationSystem
{
    public class FlightTransport : Transport
    {
        public string FlightNumber { get; set; }
        public override void Travel()
        {
            Console.WriteLine("\t ------ UÇAK YOLCULUĞU ------ \n");
            Console.WriteLine($"Uçak ile {Destination} konumuna varıldı.\n" +
                $"Uçuş no : {FlightNumber}\n" +
                $"Ücret : {Price:N0} TL\n" +
                $"Yolculuk tarihi : {TravelDate:dd.MM.yyyy}  ");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
