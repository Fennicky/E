using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class InventoryItem : INotifyPropertyChanged
    {
        public Item _details;
        public int _quantity;
        public event PropertyChangedEventHandler PropertyChanged;

        public int ItemID
        {
            get { return Details.ID; }
        }

        public int Price
        {
            get { return Details.price; }
        }

        public Item Details
        {
            get { return _details; }
            set { _details = value; OnPropertyChanged("Details"); }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value;  OnPropertyChanged("Quantity"); OnPropertyChanged("Description"); }
        }

        public string Description
        {
            get
            {
                return Quantity > 1 ? Details.namePlural :
                    Details.name;
            }
        }

        public InventoryItem(Item _details, int _quantity)
        {
            Details = _details;
            Quantity = _quantity;
        }


        protected void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
