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
                    default:
                        Console.WriteLine("Input could not be recognized");
                        continue;
                }
                break;
            }
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

                        }else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    case ("east"):
                        if (Program.playerr.currentRoom.eastexit)
                        {
                            Console.WriteLine(Program.playerr.currentRoom.eastdesc);
                            Program.playerr.currentRoom = Program.gameWorld.rooms[Program.posx +1, Program.posy];
                            Program.posx++;
                            
                        }else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    case ("south"):
                        if (Program.playerr.currentRoom.southexit)
                        {
                            Console.WriteLine(Program.playerr.currentRoom.southdesc);
                            Program.playerr.currentRoom = Program.gameWorld.rooms[Program.posx, Program.posy++];
                            Program.posy++;
                            
                        }else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    case ("west"):
                        if (Program.playerr.currentRoom.westexit)
                        {
                            Console.WriteLine(Program.playerr.currentRoom.westdesc);
                            Program.playerr.currentRoom = Program.gameWorld.rooms[Program.posx--, Program.posy];
                            Program.posx--;
                            
                        }else{
                            Console.WriteLine("There is no exit in that direction");
                        }
                        break;
                    default:
                        break;
                }

            }
        }
            

    }
}
