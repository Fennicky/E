﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    public class PlayerQuest : INotifyPropertyChanged
    {
        public Quest _details;
        public bool _isCompleted;
        public event PropertyChangedEventHandler PropertyChanged;

        public Quest Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value;
                OnPropertyChanged("IsCompleted");
                OnPropertyChanged("Name");
            }
        }

        public string Name
        {
            get { return Details.name; }
        }

        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
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