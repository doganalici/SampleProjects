using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationSystem
{
    public class TrainTransport : Transport
    {
        public int WagonNumber { get; set; }
        public string SeatType { get; set; }

        public override void Travel()
        {
            Console.WriteLine("\t ------ TREN YOLCULUĞU ------ \n");
            Console.WriteLine($"Tren ile {Destination} konumuna varıldı.\n" +
                $"Vagon numarası : {WagonNumber}\n" +
                $"Koltuk tipi : {SeatType}\n" +
                $"Ücret : {Price:N0} TL\n" +
                $"Yolculuk tarihi : {TravelDate:dd.MM.yyyy}");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
