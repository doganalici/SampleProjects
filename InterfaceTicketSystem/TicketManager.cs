using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTicketSystem
{
    public class TicketManager
    {
        private List<Ticket> soldTickets = new List<Ticket>();
        private readonly ITicketService _ticketService;

        public TicketManager(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public void Purchase(string film, int seat, int salary)
        {
            _ticketService.Purchase(film, seat, salary);
            Ticket ticket = new Ticket
            {
                Film = film,
                Seat = seat,
                Price = salary,
                Date = DateTime.Now
            };
            soldTickets.Add(ticket);

            //Report(film, seat);
            Console.WriteLine("********************************************************");
        }

        public void UpdatePrice(string film, int newPrice)
        {
            _ticketService.UpdatePrice(film, newPrice);
        }
        //public void Report(string film, int seat)
        //{
        //    Console.WriteLine($"Satın alınan filmin adı : {film}\n" +
        //        $"Satın alınan koltuk numarası : {seat}");
        //}


        public void ShowAllReport()
        {
            Console.WriteLine("\t\t ---- SATILAN BİLETLER ---");
            foreach (var ticket in soldTickets)
            {
                Console.WriteLine($"Film : {ticket.Film}\n" +
                    $"Koltuk no : {ticket.Seat}\n" +
                    $"Fiyat : {ticket.Price}\n" +
                    $"Satın alma tarihi : {ticket.Date:dd.MM.yyyy HH:mm}");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }

        }

        public void ShowTotalRevenue(string platformName)
        {
            int total = 0;
            foreach (var t in soldTickets)
            {
                total += t.Price;
            }
            Console.WriteLine($"{platformName} için toplam gelir: {total:N0} TL");
        }
    }
}