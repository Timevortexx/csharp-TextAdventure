﻿using System.Collections.Generic;

namespace TextAdventurec
{
    public class entity
    {
        public float health, mana;
        public string name;
        public int lvl, xp;
        public List<spell> spells = new List<spell>();
    }
}