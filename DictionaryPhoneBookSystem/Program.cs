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
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Kişinin adını giriniz : ");
                        string name = Console.ReadLine();

                        string phoneNumber;
                        while (true)
                        {
                            Console.Write("Kişinin numarasını giriniz : ");
                            phoneNumber = Console.ReadLine();

                            if (!long.TryParse(phoneNumber, out _) || phoneNumber.Length != 11)
                            {
                                Console.WriteLine("Geçersiz telefon numarası. Lütfen 11 haneli olacak şekilde numara girişi yapınız!");
                                continue;
                            }
                            else if (guide.ContainsKey(phoneNumber))
                            {
                                Console.WriteLine("Bu numara zaten kayıtlı ");
                                continue;
                            }
                            break;
                        }
                        guide.Add(phoneNumber, name);
                        Console.WriteLine("---Kişi başarıyla eklenmiştir--");
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.Write("Silmek istediğiniz kişinin telefon numarasını giriniz : ");
                        string deletePhoneNumber = Console.ReadLine();
                        if (guide.ContainsKey(deletePhoneNumber))
                        {
                            string keyToRemove = guide.FirstOrDefault(x => x.Key == deletePhoneNumber).Value;
                            guide.Remove(deletePhoneNumber);
                            Console.WriteLine($"{deletePhoneNumber} numarasına kayıtlı {keyToRemove} kişisi silinmiştir");
                        }
                        else
                        {
                            Console.WriteLine("\n!!!! Silmek istediğiniz numara rehberinizde bulunmuyor!");
                        }

                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("1- Numara ile arama");
                        Console.WriteLine("2- İsim ile arama");
                        Console.Write("Seçiminiz : ");
                        int searchChoice = Convert.ToInt32(Console.ReadLine());

                        if (searchChoice == 1)
                        {
                            Console.Write("Kaydını aramak istediğiniz kişinin telefon numarasını giriniz : ");
                            string searchNumber = Console.ReadLine();
                            if (guide.ContainsKey(searchNumber))
                            {
                                string foundName = guide.FirstOrDefault(x => x.Key == searchNumber).Value;
                                Console.WriteLine($"\n{searchNumber} numarası {foundName} adlı kişi olarak kayıtlıdır");
                            }
                            else
                            {
                                Console.WriteLine("\n!!!! Bu numara rehberde bulunamadı!");
                            }
                        }
                        else if (searchChoice == 2)
                        {
                            Console.Write("Kaydını aramak istediğiniz kişinin adını giriniz : ");
                            string searchName = Console.ReadLine();

                            var foundPerson = guide.Where(x => x.Value.Equals(searchName, StringComparison.OrdinalIgnoreCase)).ToList();
                            if (foundPerson.Count > 0)
                            {
                                Console.WriteLine($"\n{searchName} isimli kişi için bulunan numaralar : ");
                                foreach (var person in foundPerson)
                                {
                                    Console.WriteLine($"- {person.Key}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n!!!! Bu numara rehberde bulunamadı!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n!!! Hatalı bir tuşlama yaptınız!");
                        }

                        break;
                    case "4":
                        if (guide.Count == 0)
                        {
                            Console.WriteLine("\n!!! Rehberde kayıtlı kişi bulunmamaktadır!");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Rehber Listesi ---");
                            foreach (var person in guide)
                            {
                                Console.WriteLine($"\nİsim {person.Value}\n" +
                                    $"Telefon numarası : {person.Key}\n" +
                                    $"*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*");
                            }
                        }
                        break;
                    case "5":
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
