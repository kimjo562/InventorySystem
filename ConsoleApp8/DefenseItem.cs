using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class DefenseItem : Item
    {
        private int _defense;
        public int Defense
        {
            get
            {
                return _defense;

            }

        }

        public DefenseItem(string newName, int newDefense, int newWeight)
        {
            _name = newName;
            _defense = newDefense;
            _weight = newWeight;


        }


    }
}
