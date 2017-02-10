using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class Weapon : Item
    {
        public int minimumDamage;
        public int maximumDamage;

        public Weapon(int _id, string _name, string _namePlural, int _minimumDagage, int _maximumDamage, int _price = 0) : base(_id, _name, _namePlural, _price)
        {
            minimumDamage = _minimumDagage;
            maximumDamage = _maximumDamage;
        }
    }
}
