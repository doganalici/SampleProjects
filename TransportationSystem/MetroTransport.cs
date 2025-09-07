using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationSystem
{
    public class MetroTransport : Transport
    {
        public string LineName { get; set; }
        public int WagonCount { get; set; }

        public override void Travel()
        {
            Console.WriteLine("\t ------ METRO YOLCULUĞU ------ \n");
            Console.WriteLine($"Metro ile {Destination} konumuna varıldı.\n" +
                $"Hat adı : {LineName}\n" +
                $"Vagon sayısı : {WagonCount}\n" +
                $"Ücret : {Price:N0} TL\n" +
                $"Yolculuk tarihi : {TravelDate:dd.MM.yyyy}");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
