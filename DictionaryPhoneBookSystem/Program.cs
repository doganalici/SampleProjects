using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPhoneBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> guide = new Dictionary<string, string>();

            Console.WriteLine("Telefon Rehberine Hoş Geldiniz!");
            Console.WriteLine("--------------------------------");

            //Console.Write("Rehbere kaç kişi eklemek istiyorsunuz : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    Console.Write($"{i + 1}. kişinin adını giriniz : ");
            //    string name = Console.ReadLine();
            //    Console.Write($"{i + 1}. kişinin numarasını giriniz : ");
            //    string phoneNumber = Console.ReadLine();
            //    Console.WriteLine();
            //    guide.Add(name, phoneNumber);
            //}
            //Console.WriteLine("\nRehbet başarıyla oluşturuldu.\n");
            //foreach (var person in guide)
            //{
            //    Console.WriteLine($"İsim {person.Key}\n" +
            //        $"Telefon numarası : {person.Value}\n" +
            //        $"*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");
            //}

            bool state = true;
            while (state == true)
            {

                Console.WriteLine("\nTelefon Rehberi Menüsü:");
                Console.WriteLine("1 - Kişi Ekle");
                Console.WriteLine("2 - Kişi Sil");
                Console.WriteLine("3 - Kişi Ara");
                Console.WriteLine("4 - Rehberi Listele");
                Console.WriteLine("5 - Çıkış");
                Console.Write("Seçiminiz: ");

                Console.Write("Seçiminiz : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Kişinin adını giriniz : ");
                        string name = Console.ReadLine();
                        Console.Write("Kişinin numarasını giriniz : ");
                        string phoneNumber = Console.ReadLine();
                        if (guide.ContainsValue(phoneNumber))
                        {
                            Console.WriteLine("Bu numara zaten kayıtlı ");
                        }
                        else
                        {
                            guide.Add(name, phoneNumber);
                            Console.WriteLine("---Kişi başarıyla eklenmiştir--");
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Silmek istediğiniz kişinin telefon numarasını giriniz : ");
                        string deletePhoneNumber = Console.ReadLine();
                        if (guide.ContainsValue(deletePhoneNumber))
                        {
                            string keyToRemove = guide.FirstOrDefault(x => x.Value == deletePhoneNumber).Key;
                            guide.Remove(keyToRemove);
                            Console.WriteLine($"{deletePhoneNumber} numarasına kayıtlı {keyToRemove} kişisi siliniştir");
                        }
                        else
                        {
                            Console.WriteLine("\n!!!! Silmek istediğiniz numara rehberinizde bulunmuyor!");
                        }

                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Kaydını aramak istediğiniz kişinin telefon numarasını giriniz : ");
                        string searchNumber = Console.ReadLine();
                        if (guide.ContainsValue(searchNumber))
                        {
                            string foundName = guide.FirstOrDefault(x => x.Value == searchNumber).Key;
                            Console.WriteLine($"{searchNumber} numarası {foundName} adlı kişi olarak kayıtlıdır");
                        }
                        else
                        {
                            Console.WriteLine("\n!!!! Bu numara rehberde bulunamadı!");
                        }
                        break;
                    case 4:
                        if (guide.Count == 0)
                        {
                            Console.WriteLine("\n!!! Rehberde kayıtlı kişi bulunmamaktadır!");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Rehber Listesi ---");
                            foreach (var person in guide)
                            {
                                Console.WriteLine($"\nİsim {person.Key}\n" +
                                    $"Telefon numarası : {person.Value}\n" +
                                    $"*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");
                            }
                        }
                        break;
                    case 5:
                        state = false;
                        Console.WriteLine("\nÇıkış yapılıyor. İyi günler...");
                        break;
                    default:
                        Console.WriteLine("\n!!!!! Hatalı bir tuşlama yaptınız. Lütfen tekrar deneyin!");
                        break;
                }

            }
        }
    }
}
