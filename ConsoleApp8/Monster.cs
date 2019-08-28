using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Monster
    {
        private string _name = "";
        private int _maxHealth = 50;
        private int _health = 50;
        private int _damage = 10;


        public Monster(string name, int health, int damage)                                     // This is a constructor and can be used interchangably with other variables.
        {
            _name = name;
            _maxHealth = health;
            _health = health;
            _damage = damage;
        }

        public string GetName
        {
            get
            {
                return _name;
            }           

        }
        public int GetDamage
        {
            get
            {
                return _damage;
            }

        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;

                }
                else if (_health < 0)
                {
                    _health = 0;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Monster: " + _name);
            Console.WriteLine("Health: "+ _health + " / " + _maxHealth);
            Console.WriteLine("Combat Damage: " +_damage);
            Console.WriteLine();
        }

        public void Fight(Monster target)
        {
            int damage = GetDamage;
            //target's health - this monster's damage
            Console.WriteLine(GetName + " attacks! " + target.GetName + " takes " + _damage + " damage.");
            // Subtracts the damage from the target monster's health
            target._health -= damage;

            Console.WriteLine(target.GetName + " has " + target._health + " health.\n");

            Console.WriteLine(target.GetName + " attacks! " + GetName + " takes " + target.GetDamage + " damage.");
            _health -= target.GetDamage;

            Console.WriteLine(GetName + " has " + _health + " health.\n");

        }
    }
}
