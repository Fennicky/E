using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class Quest
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string introText { get; set; }
        public string description { get; set; }
        public int rewardExperiencePoints { get; set; }
        public int rewardGold { get; set; }
        public Item rewardItem { get; set; }
        public List<QuestCompletionItem> questCompletionItems { get; set; }

        public Quest(int _id, string _name, string _description, int _rewardExperiencePoints, int _rewardGold, string _introText = null)
        {
            ID = _id;
            name = _name;
            introText = _introText;
            description = _description;
            rewardExperiencePoints = _rewardExperiencePoints;
            rewardGold = _rewardGold;
            questCompletionItems = new List<QuestCompletionItem>();
        }
    
    }
}
