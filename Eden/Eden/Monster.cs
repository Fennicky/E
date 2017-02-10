using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int maximumDamage { get; set; }
        public int rewardExperiencePoints { get; set; }
        public int rewardGold { get; set; }
        public List<LootItem> lootTable { get; set; }
        public int spawnChance { get; set; }

        public Monster (int _id, string _name, int _maximumDamage, int _rewardExperiencePoints, int _rewardGold, int _currentHitPoints, int _maximumHitPoints, int _spawnChance = 25) : base(_currentHitPoints, _maximumHitPoints)
        {
            ID = _id;
            name = _name;
            maximumDamage = _maximumHitPoints;
            rewardExperiencePoints = _rewardExperiencePoints;
            rewardGold = _rewardGold;
            lootTable = new List<Eden.LootItem>();
            spawnChance = _spawnChance;
        }
    }
}
