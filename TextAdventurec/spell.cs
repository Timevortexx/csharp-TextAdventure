using System;
using System.Collections.Generic;
using System.Text;
namespace TextAdventurec
{
    public class spell
    {
        public string name;
        public string description;
        public int baseDmg;
        public int baseMana;
        public bool burn, posion, freeze, paralyze, bleed;

        public void cast(entity target) {
            Console.WriteLine("Cast "+name+" and hit "+target.name+ " for "+baseDmg);
            target.health -= baseDmg;
            
        }


    }
}