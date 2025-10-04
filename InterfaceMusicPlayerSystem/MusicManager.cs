using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMusicPlayerSystem
{
    public class MusicManager
    {
        private readonly IMusicPlayer _musicPlayer;
        public MusicManager(IMusicPlayer musicPlayer)
        {
            _musicPlayer = musicPlayer;
        }
        public void StartPlaying(string song)
        {
            _musicPlayer.Play(song);
        }
        public void PauseMusic()
        {
            _musicPlayer.Pause();
        }
    }
}
