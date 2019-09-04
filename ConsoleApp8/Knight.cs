﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Knight : Character 
    {
        public Knight(string name) : base(name)
        {
            _maxHealth = 150;
            _health = 150;
            _mana = 30;
            _strength = 8;
            _dexterity = 5;
            _wisdom = 2;
            _defense = 0;                              //This can change the characters base defense (Default 0)


        }

    }
}
