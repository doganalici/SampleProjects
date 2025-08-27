using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTrackingSystem
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public bool ViewStatus { get; set; }

        public void MovieInfo()
        {
            Console.WriteLine($"Film Id : {Id}");
            Console.WriteLine($"Film Adı : {Name}");
            Console.WriteLine($"Film Türü : {Type}");
            Console.WriteLine($"Film Süresi (Dakika) : {Duration}");
            if (ViewStatus == true)
            {
                Console.WriteLine($"Film İzlenme Durumu : İzlendi");
            }
            else
            {
                Console.WriteLine($"Film İzlenme Durumu : İzlenmedi");
            }
            Console.WriteLine("\n******************************************************\n");
        }
        public void MarkAsWatched()
        {
            ViewStatus = true;
            Console.WriteLine($"{Name} filmi izlendi olarak güncellenmiştir.");
            MovieInfo();
        }
        public void UpdateDuration(int NewDuration)
        {
            if (NewDuration < 20)
            {
                Console.WriteLine("Hatalı film süresi girişi yapılmıştır.");
            }
            else
            {
                Duration = NewDuration;
                Console.WriteLine($"{Name} filminin süresi güncellenmiştir.");
                MovieInfo();
            }
        }

    }
}
