using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
            _health = 85;
            _mana = 200;
            _strength = 2;
            _dexterity = 4;
            _wisdom = 8;


        }

    }
}
