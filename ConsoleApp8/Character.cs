using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Character : Entity
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 800, 1500 };                // In slot 1 or (to level up to level 2) it requires 100 XP. slot 2 (300 XP for Level 3 ect.)

        private Inventory inventory = new Inventory();                      // Creating an inventory for each character made.



        protected int _health = 100;                                        // Can be changed by inherited class. (protected int)
        protected int _maxHealth = 100;
        protected int _mana = 100;                                          // (private int) cannot be change by inherited class.
        protected int _strength = 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;


        public Character(string name)
        {
            _name = name;
            _health = 100;
            _maxHealth = 100;

        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            // return total damage
            return _strength + inventory.ItemDamage();

        }

        public override void Print()                                     // This is a constructor and can be used interchangably with other variables.
        {
            Console.WriteLine(_name + "          Level: " + _level + "    XP: " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana + "\n");
            Console.WriteLine("Stats");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Combat Damage: " + (_strength + inventory.ItemDamage()));
            Console.WriteLine("Strength: " + _strength);
            Console.WriteLine("Dexterity: " + _dexterity);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine();

        }

        public void openInventory()
        {
            inventory.Menu();                                   // Opens the inventory of the player.

        }

        public int Experience                                   // This is a Property and do not need the () after the name.
        {
            get                                                 // This will grab value set.
            {
                return _xp;                                     // Uses Value and then returns the Value after running the set{}

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

        public override void Fight(Entity target)
        {
            if (Health <= 0)
            {
                return;
            }

            int damage = GetDamage();
            //target's health - this monster's damage
            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " takes " + damage + " damage.");
            // Subtracts the damage from the target monster's health
            target.Health -= damage;
            Console.WriteLine(target.GetName() + " has " + target.Health + " health.\n");

        }

        public void Fight(Entity[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            bool validInput = false;
            while (!validInput)
            {
                int choice = 0;
                Console.WriteLine("\nWho will " + GetName() + " fight? ");
                for (int i = 0; i < targets.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + targets[i].GetName());

                }
                choice = Convert.ToInt32(Console.ReadLine());               // Grab Input

                if (choice >= 0 && choice <= targets.Length)
                {
                    validInput = true;
                    //Fight the Chosen Target
                    Console.WriteLine("\nFight " + targets[choice - 1].GetName());                  //checking if it works
                    Console.WriteLine();
                    Fight(targets[choice - 1]);
                }
            }

        }

    }
}



