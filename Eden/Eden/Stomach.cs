using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden
{
    class Stomach
    {

        public string stomachName;
        public int maxCapacity, capacity, fullness, hiddenFullness, hunger, burstResist; //TODO: Make custom UI namefields
        public bool makesWaste;
        public int waste;
        public int stretchCount, elasticity;

        public int acidStrength, speed, efficiency;
        public ArrayList eatenObjects;

        //Default basic tummy :)
        public Stomach()
        {
            //debug OP
            stomachName = "tummy";
            maxCapacity = 150;
            capacity = 100;
            fullness = 0;
            hiddenFullness = 0;
            hunger = burstResist = 100;
            makesWaste = true;
            acidStrength = 100;
            speed = 100;
            efficiency = 100;
            stretchCount = 0;
        }

        public Stomach(string _stomachName, int _maxCapacity, int _fullness, int _hiddenFullness, int _hunger, int _burstresist, bool _makesWaste, int _waste, int _acidstrength, int _speed, int _efficiency, ArrayList _eatenObjects)
        {

            stomachName = _stomachName;
            maxCapacity = _maxCapacity;
            fullness = _fullness;
            hiddenFullness = _hiddenFullness;
            hunger = _hunger;
            burstResist = _burstresist;
            makesWaste = _makesWaste;
            acidStrength = _acidstrength;
            speed = _speed;
            efficiency = _efficiency;
            eatenObjects = _eatenObjects;
            elasticity = 100;
            stretchCount = 0;
        }

        public void ingest(Food food)
        {
            eatenObjects.Add(food);

            fullness += food.fillingAmount;
            hiddenFullness += food.fillingAmount;
            if(fullness > capacity)
            {
                stretchCount++;
                stretch();
            }

            if (hiddenFullness > maxCapacity)
            {
                burst();
            }            
        }        

        public void stretch()
        {
            if(stretchCount > 5)
            {
                //IncreaseSize of tummy
                capacity += 10;
                maxCapacity = capacity + (capacity/2);
            }
        }

        public int digest()
        {
            //For now returns the fat gained from digesting
            int fat = 0;
            int d = acidStrength * speed;
            fullness -= d;
            fat += d * efficiency;
            hiddenFullness += d - efficiency;
            
            if (fullness < 0)
            {
                fat += fullness * efficiency;
                fullness = 0;
            }
                        
            int temp = hiddenFullness;
            hiddenFullness -= speed;

            if(hiddenFullness < 0 )
            {
                hiddenFullness = 0;
            }

            if (makesWaste)
            {
                waste += temp - hiddenFullness;
            }

            return fat;
        }

        public void dump()
        {
            //Empty self
            waste = 0;
        }

        public void burst()
        {
            if((fullness + hiddenFullness + waste) > maxCapacity * burstResist)
            {
                //Player burst and they died
                Console.WriteLine("Player burst ");
                dump();
            }
        }

    }
}
