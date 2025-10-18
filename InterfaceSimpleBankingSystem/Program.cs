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
            int secim;

            IBankService ziraat = new ZiraatBank(ziraataccount);
            IBankService vakif = new VakifBank(vakifaccount);
            IBankService garanti = new GarantiBank(garantiaccount);

            Console.WriteLine("Basit bankacılık sistemine hoş geldiniz.");
            Console.WriteLine("----------------------------------------\n");
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

                if (!int.TryParse(giris, out secim))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                    continue; // tekrar ana menüye dön
                }

                switch (secim)
                {

                    case 1:
                        bool ziraatMenusu = true;
                        while (ziraatMenusu)
                        {
                            Console.WriteLine("\nZiraat Bankası için hangi işlem yapılacak?\n" +
                                "1- Para Çekme\n" +
                                "2- Para Yatırma\n" +
                                "3- Bakiye Öğrenme\n" +
                                "4- Banka Menüsüne Dön");

                            int ziraatSecim;
                            Console.Write("Seçiminiz : ");
                            string ziraatGiris = Console.ReadLine();

                            if (!int.TryParse(ziraatGiris, out ziraatSecim))
                            {
                                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                                continue; // tekrar ana menüye dön
                            }
                            switch (ziraatSecim)
                            {
                                case 1:
                                    Console.Write("\nÇekilecek para miktarı : ");
                                    int cekilecek = Convert.ToInt32(Console.ReadLine());
                                    ziraat.Withdraw(cekilecek);
                                    ziraat.CheckBalance();
                                    break;
                                case 2:
                                    Console.Write("\nYatırılacak para miktarı : ");
                                    int yatirilacak = Convert.ToInt32(Console.ReadLine());
                                    ziraat.Deposit(yatirilacak);
                                    ziraat.CheckBalance();
                                    break;
                                case 3:
                                    ziraat.CheckBalance();
                                    break;
                                case 4:
                                    ziraatMenusu = false;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                                    break;
                            }
                        }
                        break;

                    case 2:
                        bool vakifMenusu = true;
                        while (vakifMenusu)
                        {
                            Console.WriteLine("\nVakıf Bankası için hangi işlem yapılacak?\n" +
                            "1- Para Çekme\n" +
                            "2- Para Yatırma\n" +
                            "3- Bakiye Öğrenme\n" +
                            "4- Banka Menüsüne Dön");
                            int vakifSecim;
                            Console.Write("Seçiminiz : ");
                            string vakifGiris = Console.ReadLine();

                            if (!int.TryParse(vakifGiris, out vakifSecim))
                            {
                                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                                continue; // tekrar ana menüye dön
                            }
                            switch (vakifSecim)
                            {
                                case 1:
                                    Console.Write("\nÇekilecek para miktarı : ");
                                    int cekilecek = Convert.ToInt32(Console.ReadLine());
                                    vakif.Withdraw(cekilecek);
                                    vakif.CheckBalance();
                                    break;
                                case 2:
                                    Console.Write("\nYatırılacak para miktarı : ");
                                    int yatirilacak = Convert.ToInt32(Console.ReadLine());
                                    vakif.Deposit(yatirilacak);
                                    vakif.CheckBalance();
                                    break;
                                case 3:
                                    vakif.CheckBalance();
                                    break;
                                case 4:
                                    vakifMenusu = false;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        bool garantiMenusu = true;
                        while (garantiMenusu)
                        {
                            Console.WriteLine("\nGaranti Bankası için hangi işlem yapılacak?\n" +
                            "1- Para Çekme\n" +
                            "2- Para Yatırma\n" +
                            "3- Bakiye Öğrenme\n" +
                            "4- Banka Menüsüne Dön ");
                            int garantiSecim;
                            Console.Write("Seçiminiz : ");
                            string garantiGiris = Console.ReadLine();

                            if (!int.TryParse(garantiGiris, out garantiSecim))
                            {
                                Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                                continue; // tekrar ana menüye dön
                            }
                            switch (garantiSecim)
                            {
                                case 1:
                                    Console.Write("\nÇekilecek para miktarı : ");
                                    int cekilecek = Convert.ToInt32(Console.ReadLine());
                                    garanti.Withdraw(cekilecek);
                                    garanti.CheckBalance();
                                    break;
                                case 2:
                                    Console.Write("\nYatırılacak para miktarı : ");
                                    int yatirilacak = Convert.ToInt32(Console.ReadLine());
                                    garanti.Deposit(yatirilacak);
                                    garanti.CheckBalance();
                                    break;
                                case 3:
                                    garanti.CheckBalance();
                                    break;
                                case 4:
                                    garantiMenusu = false;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                                    break;
                            }
                        }
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
    }
}
