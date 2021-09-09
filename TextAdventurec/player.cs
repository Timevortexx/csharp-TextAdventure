using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventurec
{
    
    class player : entity
    {
        
        public inventory inv = new inventory();
        public room currentRoom;

        public player() {
            name = "player";
        }
        
    }
}
