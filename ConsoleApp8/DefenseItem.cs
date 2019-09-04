using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
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
        public int Weight
        {

            get
            {
                return _weight;
            }
        }
        public DefenseItem(string newName, int _itemDefense, int _armorWeight)
        {
            _name = newName;
            _defense = _itemDefense;
            _weight = _armorWeight;


        }


    }
}
