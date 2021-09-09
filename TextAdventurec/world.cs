using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventurec
{
    class world
    {
        public room[,] rooms = new room[10, 10];


        public world() {
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


        public void declareRooms() {
            rooms[4, 4].description = "A small cave. A dying campfire illuminates the place dimly. You can just about make out an exit in the north.";
            rooms[4, 4].roomitems.Add(Program.playerr.inv.getFromID(2));
            rooms[4, 4].northexit = true;
            rooms[4, 4].northdesc = "You stumble towards the small exit, a horrible stench fills your nose as you get closer.";
            rooms[4, 3].description = "You find yourself in a room with corpses. It smells horrible.";
            rooms[4, 3].eastexit = true;
            rooms[4, 3].eastdesc = "As you exit to the east it becomes brighter an brighter. You can hear a waterfall nearby";
            rooms[4, 3].southexit = true;
            rooms[4, 3].southdesc = "You go back to your starting room";
            rooms[4, 3].westexit = true;
            rooms[4, 3].westdesc = "As you exit to the west, with each step it gets hotter and hotter";


        }

    }
}
