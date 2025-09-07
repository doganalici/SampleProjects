using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport bus1 = new BusTransport()
            {
                Id = 1,
                Destination = "Ankara",
                Price = 300,
                SeatNumber = 12,
                TravelDate = DateTime.Now.AddDays(5)
            };

            Transport bus2 = new BusTransport()
            {
                Id = 2,
                Destination = "İstanbul",
                Price = 350,
                SeatNumber = 25,
                TravelDate = DateTime.Now.AddDays(2)
            };

            Transport flight1 = new FlightTransport()
            {
                Id = 3,
                Destination = "Berlin",
                Price = 5000,
                FlightNumber = "TK1933",
                TravelDate = DateTime.Now.AddDays(12)
            };

            Transport flight2 = new FlightTransport()
            {
                Id = 4,
                Destination = "New York",
                Price = 15000,
                FlightNumber = "TK001",
                TravelDate = DateTime.Now.AddDays(8)
            };

            Transport ship1 = new ShipTransport()
            {
                Id = 5,
                Destination = "Kıbrıs",
                Price = 2000,
                CabinNumber = "C12",
                TravelDate = DateTime.Now.AddDays(20)
            };

            Transport ship2 = new ShipTransport()
            {
                Id = 6,
                Destination = "İtalya",
                Price = 7000,
                CabinNumber = "B34",
                TravelDate = DateTime.Now.AddDays(15)
            };

            Transport train1 = new TrainTransport()
            {
                Id = 7,
                Destination = "Eskişehir",
                Price = 450,
                WagonNumber = 3,
                SeatType = "Yataklı",
                TravelDate = DateTime.Now.AddDays(4)
            };

            Transport train2 = new TrainTransport()
            {
                Id = 8,
                Destination = "Sivas",
                Price = 600,
                WagonNumber = 5,
                SeatType = "Normal",
                TravelDate = DateTime.Now.AddDays(10)
            };

            Transport metro1 = new MetroTransport()
            {
                Id = 9,
                Destination = "Kadıköy",
                Price = 50,
                LineName = "M4",
                WagonCount = 8,
                TravelDate = DateTime.Now.AddDays(1)
            };

            Transport metro2 = new MetroTransport()
            {
                Id = 10,
                Destination = "Taksim",
                Price = 45,
                LineName = "M2",
                WagonCount = 6,
                TravelDate = DateTime.Now.AddDays(3)
            };

            List<Transport> transports = new List<Transport>() { bus1, bus2, flight1, flight2, ship1, ship2, train1, train2, metro1, metro2 };

            foreach (Transport transport in transports)
            {
                transport.Travel();
            }
        }
    }
}
