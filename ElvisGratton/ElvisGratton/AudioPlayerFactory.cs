using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElvisGratton
{
    public class AudioPlayerFactory
    {
        static public ISimpleAudioPlayer Create(string filename)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            player.Load($"{filename}.mp3");

            return player;
        }
    }
}
