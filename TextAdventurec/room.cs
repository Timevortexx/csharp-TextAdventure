using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventurec
{
    public class room
    {
        public List<entity> entities = new List<entity>();
        public List<item> roomitems = new List<item>();
        public bool northexit, southexit, westexit, eastexit;
        public string northdesc, southdesc, westdesc, eastdesc;
        public string description;



    }
}