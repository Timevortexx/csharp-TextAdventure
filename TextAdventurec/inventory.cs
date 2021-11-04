using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventurec
{
    public class inventory
    {

        public List<item> items = new List<item>();
        public int slots = 10;
        public ids idd = new ids();


        public void add(item itemToAdd) {
            //adds item to inventory
            items.Add(itemToAdd);
        
        }

        public item getFromID(int id) {
            //returns item with the specified id
            item tempItem = new item();
            if (id < idd.names.Length)
            {
                tempItem.name = idd.names[id];
                tempItem.description = idd.description[id];
                tempItem.id = id;
                return tempItem;
            } else {
                Console.WriteLine("No such item with id "+ id);
                return null;
            }
        }

        public void changeInventorySize(int size) {
            
        
        }
    }
}
