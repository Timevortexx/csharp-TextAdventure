
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;

namespace TextAdventurec
{
    class musicManager
    {
        

        public static void checkMusic()
        {
            string fileName = "waterfall.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"music\", fileName);
            Console.WriteLine(path);
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
            

        }
    }
}
