using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletProject
{
    public class Wallet
    {
        public string Owner { get; set; }
        private decimal Cash { get; set; }
        public int CardCount { get; set; }

        public void AddMoney(decimal quantity)
        {
            if (quantity > 0)
            {
                Cash += quantity;
                Console.WriteLine($"{quantity} TL para cüzdana eklenmiştir");
                Console.WriteLine("\n***************************************\n");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
            }
        }
        public void SpendMoney(decimal quantity)
        {
            if (quantity > 0 && quantity <= Cash)
            {
                Cash -= quantity;
                Console.WriteLine($"{quantity} TL para cüzdandan harcanmıştır");
                Console.WriteLine("\n***************************************\n");
            }
            else
            {
                Console.WriteLine("Cüzdandaki paradan fazlası harcanamaz!");
            }
        }
        public decimal GetCash()
        {
            return Cash;
        }

    }
}
