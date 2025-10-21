using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimpleBankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ziraataccount = new Account
            {
                AccountHolder = "Doğan Alıcı",
                Balance = 17500
            };

            Account vakifaccount = new Account
            {
                AccountHolder = "Doğan Alıcı",
                Balance = 10250
            };

            Account garantiaccount = new Account
            {
                AccountHolder = "Doğan Alıcı",
                Balance = 7750
            };

            IBankService ziraat = new ZiraatBank(ziraataccount);
            IBankService vakif = new VakifBank(vakifaccount);
            IBankService garanti = new GarantiBank(garantiaccount);

            Console.WriteLine("Basit bankacılık sistemine hoş geldiniz.");
            Console.WriteLine("----------------------------------------\n");

            BankManager bankManager = new BankManager(ziraat, vakif, garanti);
            bankManager.AnaMenu();
        }
    }
}
