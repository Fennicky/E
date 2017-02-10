using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Eden
{
    public class LivingCreature : INotifyPropertyChanged
    {
        private int _currentHitPoints;
        private int _currentHunger;
        private int _currentFullness;
        private int _currentThirst;

         
        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }


        public int MaximumHitPoints { get; set; }
        public int MaximumFullness { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LivingCreature(int _currentHitPoints, int _maximumHitPoints)
        {
            CurrentHitPoints = _currentHitPoints;
            MaximumHitPoints = _maximumHitPoints;
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
