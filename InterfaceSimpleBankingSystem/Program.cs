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
            Console.WriteLine("-----------------------------------------\n\n");

            Console.WriteLine("\n---Ziraat Bankası İşlemi---");
            ziraat.CheckBalance();
            ziraat.Deposit(7500);
            ziraat.CheckBalance();
            ziraat.Withdraw(10200);
            ziraat.CheckBalance();

            Console.WriteLine("\n---Vakıf Bank İşlemi---");
            vakif.CheckBalance();
            vakif.Deposit(2000);
            vakif.CheckBalance();
            vakif.Withdraw(3550);
            vakif.CheckBalance();

            Console.WriteLine("\n---Garanti Bankası İşlemi---");
            garanti.CheckBalance();
            garanti.Deposit(1250);
            garanti.CheckBalance();
            garanti.Withdraw(3000);
            garanti.CheckBalance();


            Console.WriteLine("\nİşlemler tamamlandı. Program sonlandırılıyor...");
        }
    }
}
