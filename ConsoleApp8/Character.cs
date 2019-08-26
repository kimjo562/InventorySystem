using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Character
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 800, 1500 };                // In slot 1 or (to level up to level 2) it requires 100 XP. slot 2 (300 XP for Level 3 ect.)

        public Character(string name)
        {
            _name = name;

        }

        public string Name()
        {

            return _name;
        }

        public void Print()                                     // This is a constructor and can be used interchangably with other variables.
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("XP: " + _xp);

        }

        public int Experience                                   // This is a Property and do not need the () after the name.
        {
            get                                                 // This will grab value set.
            {
                return _xp;

            }
            set                                                 // Will send whatever it needs to be sent.
            {
                _xp = value;
                Console.WriteLine(_name + "has have gained experience and now has " + _xp);
                if (_level <= _requiredXP.Length)                // requiredXP.Length (Length will check the length of the array.)
                {
                    if (_xp >= _requiredXP[_level - 1])
                    {
                        _level++;
                        Console.WriteLine("You have leveled up! You are now level " + _level + ".");


                    }

                }

            }


        }

    }
}
