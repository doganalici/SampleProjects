using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTicketSystem
{
    public class Online : ITicketService
    {

        public void Purchase(string film, int seat, int salary)
        {
            Console.WriteLine($"[Online] olarak {film} filmi için {seat} numaralı koltuk {salary:N0} TL' ye satılmıştır");
        }

        public void UpdatePrice(string film, int newPrice)
        {
            Console.WriteLine($"'{film}' Filmi için online alanında tüm koltukların yeni ücreti : {newPrice:N0} TL");
        }
    }
}
