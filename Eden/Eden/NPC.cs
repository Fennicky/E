using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class NPC : LivingCreature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int maximumDamage { get; set; }
        public int rewardExperiencePoints { get; set; }
        public int rewardGold { get; set; }
        public bool immortal;
        public Quest hasQuestToGive { get; set; }
        public List<LootItem> lootTable { get; set; }

        public NPC(int _id, string _name, int _maximumDamage, int _rewardExperiencePoints, int _rewardGold, int _currentHitPoints, int _maximumHitPoints, Quest _hasQuestToGive = null, bool _immortal = false) : base(_currentHitPoints, _maximumHitPoints)
        {
            ID = _id;
            name = _name;
            maximumDamage = _maximumHitPoints;
            rewardExperiencePoints = _rewardExperiencePoints;
            rewardGold = _rewardGold;
            immortal = _immortal;
            hasQuestToGive = _hasQuestToGive;
            lootTable = new List<Eden.LootItem>();
        }

        public Quest giveQuest()
        {
            return hasQuestToGive;
        }
    }
}
