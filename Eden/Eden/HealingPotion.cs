using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class CombatItem : Item
    {
        public int amountToHeal { get; set; }

        public CombatItem(int _id, string _name, string _namePlural, int _amountToHeal, int _price = 0) : base(_id, _name, _namePlural, _price)
        {
            amountToHeal = _amountToHeal;
        }
    }
}
