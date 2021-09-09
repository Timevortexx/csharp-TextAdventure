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
            //Testing Inventory functionality
            Console.WriteLine("Testing music");
            musicManager.checkMusic();
            Console.WriteLine("Testing inventory");
            playerr.inv.add(playerr.inv.getFromID(0));
            Console.WriteLine(playerr.inv.items[0].name);
            //Testing casting spells and calculating damage
            Console.WriteLine("Testing spells and health");
            playerr.health = 20;
            playerr.mana = 6;
            spell fireball = new spell();
            fireball.name = "Fireball";
            fireball.baseDmg = 5;
            fireball.burn = true;
            fireball.baseMana = 3;
            playerr.spells.Add(fireball);
            playerr.spells[0].cast(playerr);
            Console.WriteLine("Player health: " + playerr.health);
            Console.WriteLine("Player mana: " + playerr.mana);
            Console.WriteLine("Testing za warudo");
            playerr.currentRoom = gameWorld.rooms[4, 4];
            posx = 4; posy = 4;
            Console.WriteLine(gameWorld.rooms[4,4].description);
            Console.WriteLine("What do you want to do:");
            InputParser.parse(Console.ReadLine());
            Console.WriteLine("Well now youre on your own");
            while (true)
            {
                Console.WriteLine(gameWorld.rooms[posx,posy].description);
                Console.WriteLine("What do you want to do:");
                InputParser.parse(Console.ReadLine());
            }
        }
    }
}
