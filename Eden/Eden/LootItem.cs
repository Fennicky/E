using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class LootItem
    {
        public Item details { get; set; }
        public int dropPercentage { get; set; }
        public bool isDefaultItem { get; set; }

        public LootItem(Item _details, int _dropPercentage, bool _isDefaultItem)
        {
            details = _details;
            dropPercentage = _dropPercentage;
            isDefaultItem = _isDefaultItem;
        }
    }
}
