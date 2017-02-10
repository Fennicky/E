using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string namePlural { get; set; }
        public int price { get; set; }

        public Item(int _id, string _name, string _namePlural, int _price = 0)
        {
            ID = _id;
            name = _name;
            namePlural = _namePlural;
            price = _price; //Default price is -1. A price of -1 means the item is unsellable
        }

    }
}
