using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimpleBankingSystem
{
    public class BankManager
    {
        private IBankService ziraat;
        private IBankService vakif;
        private IBankService garanti;

        public BankManager(IBankService ziraat, IBankService vakif, IBankService garanti)
        {
            this.ziraat = ziraat;
            this.vakif = vakif;
            this.garanti = garanti;
        }

        public void AnaMenu()
        {
            bool devam = true;
            while (devam)
            {
                Console.WriteLine("\nHangi bankada işlem yapmak istiyorsunuz?\n" +
                    "1- Ziraat Bankası\n" +
                    "2- Vakıf Bankası\n" +
                    "3- Garanti Bankası\n" +
                    "4- Çıkış");

                Console.Write("Seçiminiz : ");
                string giris = Console.ReadLine();

                if (!int.TryParse(giris, out int secim))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                    continue; // tekrar ana menüye dön
                }
                switch (secim)
                {
                    case 1:
                        BankaMenusu(ziraat, "Ziraat Bankası");
                        break;

                    case 2:
                        BankaMenusu(vakif, "Vakıf Bankası");
                        break;

                    case 3:
                        BankaMenusu(garanti, "Garanti Bankası");
                        break;

                    case 4:
                        devam = false;
                        Console.WriteLine("\nİşlemler tamamlandı. Çıkmak için bir tuşa basın...");
                        break;
                    default:
                        Console.WriteLine("Lütfen işlem listesindeki numaralardan seçim yapınız!");
                        break;
                }
            }
        }
        private void BankaMenusu(IBankService banka, string bankaAdi)
        {
            bool bankaMenusu = true;
            while (bankaMenusu)
            {
                Console.WriteLine($"\n{bankaAdi} Bankası için hangi işlem yapılacak?\n" +
                            "1- Para Çekme\n" +
                            "2- Para Yatırma\n" +
                            "3- Bakiye Öğrenme\n" +
                            "4- Banka Menüsüne Dön ");
                Console.Write("Seçiminiz : ");
                string giris = Console.ReadLine();
                if (!int.TryParse(giris, out int secim))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                    continue; // tekrar ana menüye dön
                }
                switch (secim)
                {
                    case 1:
                        Console.Write("\nÇekilecek para miktarı : ");
                        int cekilecek = Convert.ToInt32(Console.ReadLine());
                        banka.Withdraw(cekilecek);
                        banka.CheckBalance();
                        break;
                    case 2:
                        Console.Write("\nYatırılacak para miktarı : ");
                        int yatirilacak = Convert.ToInt32(Console.ReadLine());
                        banka.Deposit(yatirilacak);
                        banka.CheckBalance();
                        break;
                    case 3:
                        banka.CheckBalance();
                        break;
                    case 4:
                        bankaMenusu = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                        break;
                }
            }
        }
        
    }
}
