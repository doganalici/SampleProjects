using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceGameStore
{
    public class GameManager
    {
        List<Game> purchasedGames = new List<Game>();

        private readonly IGameService _gameService;

        public GameManager(IGameService gameService)
        {
            _gameService = gameService;
        }

        public void PurchaseGame(string gameName, int price)
        {
            _gameService.Purchase(gameName, price);

            var game = new Game
            {
                GameName = gameName,
                Price = price,
                DiscountedPrice = price - (price * _gameService.GetDiscountRate()),
                PurchaseDate = DateTime.Now
            };
            purchasedGames.Add(game);
        }

        public void ShowAllPurchases()
        {
            Console.WriteLine("\t\t ------ SATIN ALINAN OYUNLAR ------");
            foreach (var game in purchasedGames)
            {
                Console.WriteLine($"Oyun adı : {game.GameName}\n" +
                    $"Fiyatı : {game.Price}\n" +
                    $"İndirimli Fiyatı : {game.DiscountedPrice:N0}\n" +
                    $"Satın Alınma Tarihi : {game.PurchaseDate:dd.MM.yyyy HH:mm}");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
        }
        public void ShowLastPurchasedGames()
        {
            if (purchasedGames.Count==0)
            {
                Console.WriteLine("Henüz satın alınan oyun bulunmamakta.\n");
                return;
            }
            var lastGame=purchasedGames[purchasedGames.Count-1];
            Console.WriteLine("Satın alınan son oyun bigileri");
            Console.WriteLine($"Oyun adı : {lastGame.GameName}\n" +
                $"Oyun Fiyatı : {lastGame.Price}\n" +
                $"İndirimli Fiyatı : {lastGame.DiscountedPrice}\n" +
                $"Satın alma tarihi : {lastGame.PurchaseDate:dd.MM.yyyy HH:mm}");
            Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");
        }

        public void ShowTotalSpent()
        {
            
            double total = 0;
            foreach (var game in purchasedGames)
            {
                total += game.DiscountedPrice;
            }
            Console.WriteLine($" yapılan toplam harcama : {total:N0} TL");
        }

    }
}
