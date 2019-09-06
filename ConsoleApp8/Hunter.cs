using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Hunter : Character
    {
        public Hunter(string name, string job) : base(name, job)
        {
            _maxHealth = 150;
            _health = 150;
            _mana = 75;
            _strength = 4;
            _dexterity = 8;
            _wisdom = 4;
            _defense = 0;                              //This can change the characters base defense (Default 0)

        }


    }
}
