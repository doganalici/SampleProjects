using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMusicPlayerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Müzik Oynatıcı sistemine Hoş Geldiniz ===\n\n");
            Console.WriteLine("Lütfen bir playform seçimi yapınız:");
            Console.WriteLine("1 - Spotiyfy");
            Console.WriteLine("2 - Youtube Music");
            Console.WriteLine("3 - Apple Music");
            Console.Write("\nSeçiminiz : ");
            int choice = Convert.ToInt32(Console.ReadLine());


            IMusicPlayer selectPlayer;

            switch (choice)
            {
                case 1:
                    selectPlayer = new SpotifyPlayer();
                    break;
                case 2:
                    selectPlayer = new YouTubeMusicPlayer();
                    break;
                case 3:
                    selectPlayer = new AppleMusicPlayer();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim! Varsayılan olarak Youtube seçildi.");
                    selectPlayer = new YouTubeMusicPlayer();
                    break;
            }

            MusicManager musicManager = new MusicManager(selectPlayer);
            bool continueMusic = true;
            List<string> playedSongs = new List<string>(); //Dinlenen şarkılar listesi

            while (continueMusic)
            {
                Console.Write("Lütfen çalmak istediğiniz şarkının adını giriniz : ");
                string song = Console.ReadLine();

                musicManager.StartPlaying(song);
                musicManager.PauseMusic();
                playedSongs.Add(song);//Şarkıyı listeye ekleme
                Console.WriteLine("\n");
                Console.WriteLine("Bir sonraki şarkıya geçmek ister misiniz? (E)\nÇıkmak isterseniz farklı herhangi bir tuşa basmanız yeterli olacaktır.");
                string answer = Console.ReadLine().ToUpper();

                if (answer != "E")
                {
                    continueMusic = false;
                }
            }
            Console.WriteLine("Dinlediğiniz şarkılar: ");
            Console.WriteLine("---------------------------");
            foreach (string song in playedSongs)
            {
                Console.WriteLine($"- {song}");
            }

            Console.WriteLine("\nOynatma tamamlandı.  İyi günler...");
            Console.ReadKey();

        }
    }

}
