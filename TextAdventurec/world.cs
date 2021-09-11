using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventurec
{
    class world
    {
        public room[,] rooms = new room[10, 10];


        public world()
        {
            //initializing all rooms, to fill the array
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rooms[i, j] = new room();
                }
            }
            //writing actual rooms to the array
            declareRooms();

        }


        public void declareRooms()
        {
            rooms[4, 4].description = "A small cave. A dying campfire illuminates the place dimly.\nYou can just about make out an exit in the north.";
            rooms[4, 4].roomitems.Add(Program.playerr.inv.getFromID(2));
            rooms[4, 4].northexit = true;
            rooms[4, 4].music = true;
            rooms[4, 4].track = "cave";
            rooms[4, 4].northdesc = "You stumble towards the small exit,\na horrible stench fills your nose as you get closer.";
            rooms[4, 3].description = "You find yourself in a room with corpses. It smells horrible.";
            rooms[4, 3].eastexit = true;
            rooms[4, 3].eastdesc = "As you exit to the east it becomes brighter and\nbrighter. You can hear a waterfall nearby";
            rooms[4, 3].southexit = true;
            rooms[4, 3].southdesc = "You go back to your starting room";
            rooms[4, 3].westexit = true;
            rooms[4, 3].westdesc = "As you exit to the west, with each step it gets hotter and hotter";
            rooms[5, 3].description = "You are standing in a large ravine. There is water raging\nat the bottom and the sound of a waterfall fills\nthe area. You can see daylight coming in from the\ntop and the walls are overgrown with lush vegetation.";
            rooms[5, 3].northexit = true;
            rooms[5, 3].northdesc = "You follow the direction of a ravine until you notice a small wooden ladder. You climb it and emerge on a small sunny island";
            rooms[5, 3].eastexit = true;
            rooms[5, 3].music = true;
            rooms[5, 3].track = "waterfall";
            rooms[5, 3].eastdesc = "You notice the entrance to an underwater cave. You decide to jump in the water and follow the narrow passage way. Soon the roof stretches above the waterline and you emerge from the water.";


        }

    }
}
