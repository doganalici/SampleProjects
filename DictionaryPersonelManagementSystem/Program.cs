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

                        Personnel newPerson = new Personnel(id, firstName, lastName, department, salary, phoneNumber);
                        manager.AddPersonnel(newPerson);
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
                        Personnel updatedPersonnel = new Personnel(updateId, newFirstName, newLastName, newDepartment, newSalary, newPhoneNumber);
                        manager.UpdatePersonnel(updateId, updatedPersonnel);
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
