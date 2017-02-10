using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class Location
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Item itemRequiredToEnter { get; set; }
        public Quest questAvailableHere { get; set; }
        public Monster monsterLivingHere { get; set; }
        public List<Monster> monstersLivingHere { get; set; }
        public List<NPC> NPCsLivingHere { get; set; }
        public Location locationToNorth { get; set; }
        public Location locationToEast { get; set; }
        public Location locationToSouth { get; set; }
        public Location locationToWest { get; set; }
        public Vendor vendorWorkingHere { get; set; }

        public Location(int _id, string _name, string _description, Item _itemRequiredToEnter = null, Quest _questAvailableHere = null, Monster _monsterLivingHere = null)
        {
            ID = _id;
            name = _name;
            description = _description;
            itemRequiredToEnter = _itemRequiredToEnter;
            questAvailableHere = _questAvailableHere;
            monsterLivingHere = _monsterLivingHere;
            monstersLivingHere = new List<Monster>();
            //NPCsLivingHere = new List<NPC>();
        }
    }
}
