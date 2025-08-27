using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            wallet.Owner = "Doğan Alıcı";
            wallet.CardCount = 1;

            wallet.AddMoney(25000);
            wallet.SpendMoney(12500);
            Console.WriteLine($"Cüzdandaki paranın miktarı {wallet.GetCash()} TL");
            Console.WriteLine("---------------------------------------");
        }
    }
}
