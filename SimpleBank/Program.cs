using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu proje kapsülleme (encapsulation) örneğidir
            BankAccount account = new BankAccount();
            account.AccountNumber = 12345;
            account.OwnerName = "Doğan Alıcı";

            account.Deposit(500);
            account.Withdraw(250);
            Console.WriteLine($"Son bakiye : {account.GetBalance()} TL");
        }
    }
}
