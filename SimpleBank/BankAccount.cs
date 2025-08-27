using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        private decimal Balance { get; set; }

        //Para çekme
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} TL yatırıldı.\nYeni bakiye : {Balance}");
                Console.WriteLine("\n******************************************\n");
            }
            else
            {
                Console.WriteLine("Geçersiz miktar. Lütfen 0 dan büyük bir değer giriniz!");
            }
        }

        //Para Çekme
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} TL tutarında para çekim işlemi yapıldı.\nYeni bakiye : {Balance}");
                Console.WriteLine("\n******************************************\n");
            }
            else
            {
                Console.WriteLine("Geçersiz bakiye. Lütfen bakiyenizden küçük ya da eşit olacak şekilde tutar giriniz!");
            }
        }
        public decimal GetBalance()
        {
            return Balance;
            Console.WriteLine("\n******************************************\n");
        }
    }
}
