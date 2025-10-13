using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimpleBankingSystem
{
    public class GarantiBank : IBankService
    {

        private Account _account;

        public GarantiBank(Account account)
        {
            _account = account;
        }

        public void Deposit(double amount)
        {
            _account.Balance += amount;
            Console.WriteLine($"Garanti Bankası hesabına {amount:N0} TL para yatırılmıştır");
        }

        public void Withdraw(double amount)
        {
            if (_account.Balance >= amount)
            {
                _account.Balance -= amount;
                Console.WriteLine($"Garanti Bankası hesabından {amount:N0} TL para çekilmiştir");
            }
            else
            {
                Console.WriteLine("Çekmek istediğiniz tutar bakiyenizden büyüktür. İşlem iptal edildi. Yetersiz bakiye!");
            }

        }
        public void CheckBalance()
        {
            Console.WriteLine($"Garanti Bankası hesap bakiyesi : {_account.Balance:N0} TL");
        }
    }
}
