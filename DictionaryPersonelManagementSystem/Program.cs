using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPersonelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            Console.WriteLine(" ---- PERSONEL YÖNETİM SİSTEMİ ----");
            bool state = true;
            while (state)
            {
                Console.WriteLine();
                Console.WriteLine("1- Personel Ekle");
                Console.WriteLine("2- Personel Sil");
                Console.WriteLine("3- Personel Güncelle");
                Console.WriteLine("4- Personel Ara");
                Console.WriteLine("5- Tüm Personelleri Listele");
                Console.WriteLine("6- Çıkış");

                Console.Write("\nSeçiminiz : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("İsim : ");
                        string firstName = Console.ReadLine();
                        Console.Write("Soyisim : ");
                        string lastName = Console.ReadLine();
                        Console.Write("Departman : ");
                        string department = Console.ReadLine();
                        Console.Write("Maaş : ");
                        decimal salary = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Telefon Numarası : ");
                        string phoneNumber = Console.ReadLine();

                        //Personnel newPerson = new Personnel(id, firstName, lastName, department, salary, phoneNumber);
                        //manager.AddPersonnel(newPerson);

                        if (phoneNumber.All(char.IsDigit) && phoneNumber.Length == 11)
                        {
                            Personnel newPerson = new Personnel(id, firstName, lastName, department, salary, phoneNumber);
                            manager.AddPersonnel(newPerson);
                            
                        }
                        else
                        {
                            Console.WriteLine("Hata: Telefon numarası yalnızca 11 haneli rakamlardan oluşmalıdır!");
                        }
                        break;
                    case 2:
                        Console.Write("Silmek istediğiniz personelin ID numarasını giriniz : ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        manager.DeletePersonnel(deleteId);
                        break;
                    case 3:
                        Console.Write("Güncellemek istediğiniz personelin ID numarasını giriniz : ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        if (!manager.HasPersonnel(updateId))
                        {
                            Console.WriteLine("\nBu ID'ye sahip bir personel bulunamadı. Güncelleme işlemi iptal edildi.\n");
                            break; // Menüye geri dön
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("1- Tüm bilgileri güncelle");
                            Console.WriteLine("2- Belirli bir bilgiyi güncelle");
                            Console.Write("Seçiminiz : ");
                            int suboption = Convert.ToInt32(Console.ReadLine());
                            switch (suboption)
                            {
                                case 1:
                                    Console.WriteLine("\nYeni bilgileri giriniz : ");
                                    Console.Write("İsim : ");
                                    string newFirstName = Console.ReadLine();
                                    Console.Write("Soyisim : ");
                                    string newLastName = Console.ReadLine();
                                    Console.Write("Departman : ");
                                    string newDepartment = Console.ReadLine();
                                    Console.Write("Maaş : ");
                                    decimal newSalary = Convert.ToDecimal(Console.ReadLine());
                                    Console.Write("Telefon numarası : ");
                                    string newPhoneNumber = Console.ReadLine();
                                    if (newPhoneNumber.All(char.IsDigit) && newPhoneNumber.Length==11)
                                    {
                                        Personnel updatedPersonnel = new Personnel(updateId, newFirstName, newLastName, newDepartment, newSalary, newPhoneNumber);
                                        manager.UpdatePersonnel(updateId, updatedPersonnel);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hata: Telefon numarası yalnızca 11 haneli rakamlardan oluşmalıdır!");
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("\nHangi bilgiyi güncellemek istersiniz?");
                                    Console.WriteLine("1 - Ad\n2 - Soyad\n3 - Departman\n4 - Maaş\n5 - Telefon");
                                    Console.Write("Seçiminiz : ");
                                    int selection = Convert.ToInt32(Console.ReadLine());
                                    switch (selection)
                                    {
                                        case 1:
                                            Console.Write("\nYeni isim bilgisini giriniz : ");
                                            string updateFirstName = Console.ReadLine();
                                            manager.UpdatePersonnelField(updateId, selection, updateFirstName);
                                            break;
                                        case 2:
                                            Console.Write("\nYeni soyisim bilgisini giriniz : ");
                                            string updateLastName = Console.ReadLine();
                                            manager.UpdatePersonnelField(updateId, selection, updateLastName);
                                            break;
                                        case 3:
                                            Console.Write("\nYeni departman bilgisini giriniz : ");
                                            string updateDepartment = Console.ReadLine();
                                            manager.UpdatePersonnelField(updateId, selection, updateDepartment);
                                            break;
                                        case 4:
                                            Console.Write("\nYeni maaş bilgisini giriniz : ");
                                            string updateSalary = (Console.ReadLine());
                                            manager.UpdatePersonnelField(updateId, selection, updateSalary);
                                            break;
                                        case 5:
                                            Console.Write("\nYeni telefon bilgisini giriniz : ");
                                            string updatePhoneNumber = Console.ReadLine();
                                            manager.UpdatePersonnelField(updateId, selection, updatePhoneNumber);
                                            break;
                                        default:
                                            Console.WriteLine("Lütfen menüye göre tuşlama yapınız!");
                                            break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Lütfen menüye göre tuşlama yapınız!");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Aramak istediğiniz personelin ID numarasını giriniz : ");
                        int findId = Convert.ToInt32(Console.ReadLine());
                        manager.FindPersonnel(findId);
                        break;
                    case 5:
                        Console.WriteLine();
                        manager.ListAll();
                        break;
                    case 6:
                        Console.WriteLine("Çıkış yapılıyor...");
                        state = false;
                        break;
                    default:
                        Console.WriteLine("Lütfen menüye göre tuşlama yapınız!");
                        break;
                }
            }
        }
    }
}
