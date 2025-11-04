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
        public void AddPersonnel(Personnel p)
        {
            if (!staff.ContainsKey(p.Id))
            {
                staff.Add(p.Id, p);
                Console.WriteLine($"{p.FirstName} {p.LastName} başarıyla eklenmiştir");
            }
            else
            {
                Console.WriteLine("Bu ID'ye sahip bir personel zaten mevcut.\n");
            }
        }

        public void DeletePersonnel(int id)
        {
            if (staff.ContainsKey(id))
            {
                staff.Remove(id);
                Console.WriteLine($"ID : {id} olan personel kayıtlardan silinmiştir");
            }
            else
            {
                Console.WriteLine("Bu ID'ye sahip personel bulunamadı.");
            }
        }
        public void UpdatePersonnel(int id, Personnel newInformation) { }
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
        public void FindPersonnel(int id) { }

    }
}
