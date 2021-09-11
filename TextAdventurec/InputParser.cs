using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventurec
{
    class InputParser
    {

        public static void parse(string input) {
            string[] sinputs = input.Split(" ");
            foreach (var sinput in sinputs)
            {
                switch (sinput)
                {
                    //parse walking
                    case ("walk"):
                    case ("go"):
                    case ("move"):
                        walk(sinputs);
                        break;
                    case ("pos"):
                        pos();
                        break;
                    default:
                        Console.WriteLine("Input could not be recognized");
                        continue;
                }
                break;
            }
        }

        private static void pos()
        {
            Console.WriteLine(Program.posx + " : " + Program.posy);
        }

        public static void walk(string[] sinputs) {
            foreach (var sinput in sinputs)
            {
                switch (sinput)
                {
                    case ("north"):
                        if (Program.playerr.currentRoom.northexit)
                        {
                            Console.WriteLine(Program.playerr.currentRoom.northdesc);
                            Program.playerr.currentRoom = Program.gameWorld.rooms[Program.posx, Program.posy - 1];
                            Program.posy--;
                            play_music(Program.playerr.currentRoom.track);

                        }
                        else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    case ("east"):
                        if (Program.playerr.currentRoom.eastexit)
                        {
                            Console.WriteLine(Program.playerr.currentRoom.eastdesc);
                            Program.playerr.currentRoom = Program.gameWorld.rooms[Program.posx +1, Program.posy];
                            Program.posx++;
                            play_music(Program.playerr.currentRoom.track);

                        }
                        else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    case ("south"):
                        if (Program.playerr.currentRoom.southexit)
                        {
                            Console.WriteLine(Program.playerr.currentRoom.southdesc);
                            Program.playerr.currentRoom = Program.gameWorld.rooms[Program.posx, Program.posy+1];
                            Program.posy++;
                            play_music(Program.playerr.currentRoom.track);

                        }
                        else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    case ("west"):
                        if (Program.playerr.currentRoom.westexit)
                        {
                            Console.WriteLine(Program.playerr.currentRoom.westdesc);
                            Program.playerr.currentRoom = Program.gameWorld.rooms[Program.posx-1, Program.posy];
                            Program.posx--;
                            play_music(Program.playerr.currentRoom.track);
                            
                        }else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    default:
                        break;
                }

            }
        }

        public static void play_music(string track) {
            if (Program.playerr.currentRoom.music) { 
            musicManager.checkMusic(track);
            }
        }
            

    }
}
