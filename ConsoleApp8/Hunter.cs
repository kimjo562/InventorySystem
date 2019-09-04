using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Hunter : Character
    {
        public Hunter(string name) : base(name)
        {
            _maxHealth = 250;
            _health = 150;
            _mana = 75;
            _strength = 4;
            _dexterity = 8;
            _wisdom = 4;


        }


    }
}
