using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGameStore
{
    public interface IGameService
    {
        void Purchase(string gameName, int price);
        double GetDiscountRate();
    }
}
