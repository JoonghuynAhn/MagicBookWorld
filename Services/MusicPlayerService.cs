using CommunityToolkit.Maui.Views;
using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBookWorld.Services
{
    public static class MusicPlayerService
    {
        //private MediaPlayer _mediaPlayer;
        //private readonly IAudioManager audioManager;
        private static IAudioPlayer player; // Declare at the class level
        public static async Task CreateAudioManager(string songPath)
        {
            player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(songPath));
            player.Play();
        }

        public static void Play()
        {
            player.Play();
        }

        public static void Dispose()
        {
            player.Dispose();
        }

        public static void Stop()
        {
            player.Dispose();
        }
        
        public static async void musicPlayer(string songPath)
        {
            await CreateAudioManager(songPath);
            Play();
            //createMusicPlayer = MusicPlayerService.CreateAudioManager("sample.mp3");
        }
    }
}
