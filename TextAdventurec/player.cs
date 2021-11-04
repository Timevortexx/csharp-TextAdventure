using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventurec
{
    
    class player : entity
    {
        
        
        public room currentRoom;
        public room prevRoom;
        public bool litup;
        public item lightitem;

        public player() {
            name = "player";
        }
        
    }
}
