using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGameStore
{
    public class EpicGames : IGameService
    {
        public double GetDiscountRate()
        {
            return 0.2;
        }

        public void Purchase(string gameName, int price)
        {
            Console.WriteLine($"[Epic Games] {gameName} oyunu;\n" +
                $"{price:N0} TL tutarındayken %20 indirimle {price * 0.8:N0} TL ye alınmıştır\n");
        }
    }
}
