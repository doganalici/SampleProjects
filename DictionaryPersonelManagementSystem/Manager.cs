using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPersonelManagementSystem
{
    public class Manager
    {
        private Dictionary<int, Personnel> staff = new Dictionary<int, Personnel>();

        public bool HasPersonnel(int id)
        {
            return staff.ContainsKey(id);
        }
        public void AddPersonnel(Personnel p)
        {
            if (!staff.ContainsKey(p.Id))
            {
                staff.Add(p.Id, p);
                Console.WriteLine($"\n{p.FirstName} {p.LastName} başarıyla eklenmiştir");
            }
            else
            {
                Console.WriteLine("\nBu ID'ye sahip bir personel zaten mevcut.\n");
            }
        }

        public void DeletePersonnel(int id)
        {
            if (staff.ContainsKey(id))
            {
                staff.Remove(id);
                Console.WriteLine($"\nID : {id} olan personel kayıtlardan silinmiştir");
            }
            else
            {
                Console.WriteLine("\nBu ID'ye sahip personel bulunamadı.");
            }
        }
        public void UpdatePersonnel(int id, Personnel newInformation)
        {
            if (staff.ContainsKey(id))
            {
                staff[id] = newInformation;
                Console.WriteLine($"\n{id} numaralı personel bilgileri güncellenmiştir.\n");
            }
            else
            {
                Console.WriteLine("\n!!! Güncellenmek istenen personel bulunamadı.\n");
            }
        }
        public void ListAll()
        {
            if (staff.Count == 0)
            {
                Console.WriteLine("\nListelenecek herhangi bir personel kaydı bulunamadı!");
                return;
            }
            foreach (var p in staff)
            {
                Console.WriteLine(p.Value);
                Console.WriteLine(new string('*', 25));
            }
        }
        public void FindPersonnel(int id)
        {
            if (staff.ContainsKey(id))
            {
                Console.WriteLine(staff[id]);
            }
            else
            {
                Console.WriteLine("\nBu ID' ye sahip personel bulunamadı.\n");
            }
        }

        public void UpdatePersonnelField(int id, int fieldOption, string newValue)
        {
            if (!staff.ContainsKey(id))
            {
                Console.WriteLine("\nBu ID' ye sahip personel bulunamadı.\n");
            }
            else
            {
                Personnel person = staff[id];
                switch (fieldOption)
                {
                    case 1:
                        person.UpdateFirstName(newValue);
                        break;
                    case 2:
                        person.UpdateLastName(newValue);
                        break;
                    case 3:
                        person.UpdateDepartment(newValue);

                        break;
                    case 4:
                        try
                        {
                            decimal newSalary = Convert.ToDecimal(newValue);
                            person.UpdateSalary(newSalary);
                        }
                        catch (FormatException)
                        {

                            Console.WriteLine("!!! HATA : Maaş değeri sayısal olmalıdır!");
                        }

                        break;
                    case 5:
                        if (newValue.All(char.IsDigit) && newValue.Length==11)
                        {
                            person.UpdatePhoneNumber(newValue);
                        }
                        else
                        {
                            Console.WriteLine("Hata: Telefon numarası yalnızca 11 haneli rakamlardan oluşmalıdır!");
                        }
                            break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız!");
                        break;
                }
            }
        }

    }
}
