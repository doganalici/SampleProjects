using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGameStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var steam = new GameManager(new Steam());
            var epic = new GameManager(new EpicGames());

            Console.WriteLine("\t\t ------- STEAM GAMES -------");
            steam.PurchaseGame("Red Dead Redemption 2", 1500);
            steam.PurchaseGame("Cyberpunk 2077", 1200);
            steam.PurchaseGame("The Witcher 3: Wild Hunt", 800);
            steam.PurchaseGame("Resident Evil 4 Remake", 1100);

            Console.WriteLine("\n\t\t ------- EPİC GAMES -------");
            epic.PurchaseGame("Alan Wake 2", 1200);
            epic.PurchaseGame("Fortnite (Battle Pass)", 350);
            epic.PurchaseGame("Control Ultimate Edition", 700);
            epic.PurchaseGame("Death Stranding Director’s Cut", 1150);


            steam.ShowAllPurchases();
            epic.ShowAllPurchases();

            Console.WriteLine("\t\t\n ------ YAPILAN TOPLAM HARCAMA ------");
            Console.Write("Steam için");
            steam.ShowTotalSpent();
            Console.Write("Epic Games için");
            epic.ShowTotalSpent();

            Console.WriteLine("\t\t\n ------ SATIN ALINAN SON OYUNLAR ------\n");
            steam.ShowLastPurchasedGames();
            epic.ShowLastPurchasedGames();



        }
    }
}
