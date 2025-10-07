using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGameStore
{
    public class Steam : IGameService
    {
        public double GetDiscountRate()
        {
            return 0.1;
        }

        public void Purchase(string gameName, int price)
        {
            Console.WriteLine($"[Steam] {gameName} oyunu;\n" +
                $"{price:N0} TL tutarındayken %10 indirimle {price*0.9:N0} TL ye alınmıştır\n");
        }
    }
}
