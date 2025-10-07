using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTicketSystem
{
    public class BoxOffice : ITicketService
    {
        public void Purchase(string film, int seat, int salary)
        {
            Console.WriteLine($"[Gişede] {film} filmi için {seat} numaralı koltuk {salary:N0} TL' ye satılmıştır");
        }

        public void UpdatePrice(string film,int newPrice)
        {
            Console.WriteLine($"'{film}' Filmindeki tüm koltukların gişedeki yeni ücreti : {newPrice:N0} TL");
        }
    }
}
