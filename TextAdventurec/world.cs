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
            rooms[4, 4].northdesc = "You stumble towards the small exit, a horrible stench fills your nose as you get closer. As you exit the small cave room you find yourself in a room with hundereds of corpses. There is an exit to the east, west and south";
            
        
        }

    }
}
