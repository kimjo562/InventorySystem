using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Wizard : Character
    {
        public Wizard(string name, string job) : base(name, job)
        {
            _maxHealth = 85;
            _health = 85;
            _mana = 200;
            _strength = 2;
            _dexterity = 4;
            _wisdom = 8;
            _defense = 0;                               //This can change the characters base defense (Default 0)

        }

    }
}
