using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMusicPlayerSystem
{
    public class SpotifyPlayer : IMusicPlayer
    {
        public void Pause()
        {
            Console.WriteLine("Müzik duraklatıldı");
        }

        public void Play(string song)
        {
            Console.WriteLine($"{song} adlı şarkı Spotify'da çalıyor");
        }
    }
}
