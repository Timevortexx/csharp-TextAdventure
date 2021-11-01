

using System;

namespace TextAdventurec
{
    class Program
    {
        public static player playerr = new player();
        public static world gameWorld = new world();
        public static int posx, posy;

        static void Main(string[] args)
        {
            Console.SetWindowSize(62, 32);
            playerr.currentRoom = gameWorld.rooms[4, 4];
            playerr.lightitem = playerr.inv.getFromID(2);
            playerr.litup = true;
            posx = 4; posy = 4;
            InputParser.DrawWindowTop();
            if (playerr.currentRoom.music)
            {
                musicManager.checkMusic(playerr.currentRoom.track);
            }
            InputParser.DrawWindow();
            while (true)
            {
                int top = Console.CursorTop;
                graphics.drawImage();
                Console.SetCursorPosition(0, top);      
                InputParser.parse(Console.ReadLine());
                
            }
        }
    }
}
