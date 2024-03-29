﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Character : Entity
    {
        private string _name = "";
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 800, 1500 };                // In slot 1 or (to level up to level 2) it requires 100 XP. slot 2 (300 XP for Level 3 ect.)

        private Inventory inventory = new Inventory();                      // Creating an inventory for each character made.

        protected int _mana = 100;                                          // (private int) cannot be change by inherited class.
        protected int _strength = 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;
        protected int _defense = 0;
        protected string _job = "None";


        public Character(string name, string job)
        {
            _name = name;
            _job = job;

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

        public override int GetDefense()
        {
            // return current defense.
            return _defense + inventory.ItemDefense();

        }

        public override int GetLevel()
        {
            return _level;
        }

        public override string GetJob()
        {
            return _job;

        }

        public override void Print()                                     // This is a constructor and can be used interchangably with other variables.
        {
            Console.WriteLine(_name + "          Level: " + _level + "    XP: " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana + "\n");
            Console.WriteLine("Stats");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Combat Damage: " + (_strength + inventory.ItemDamage()));
            Console.WriteLine("Combat Defense: " + (_defense + inventory.ItemDefense()));
            Console.WriteLine("Strength: " + _strength);
            Console.WriteLine("Dexterity: " + _dexterity);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine();

        }

        public override void openInventory()
        {
            Console.Write(GetName()+ "'s ");
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
                Console.WriteLine(_name + " has have gained experience and now has " + _xp);
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
            int defense = GetDefense();
            //target's health - this monster's damage
            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " takes " + damage + " damage, but blocked by "+ target.GetDefense() + " armor.");
            // Subtracts the damage from the target monster's health
            damage -= target.GetDefense();
            target.Health -= damage;
            Console.WriteLine(target.GetName() + " has " + target.Health + " health.\n");

        }

        public override void Load(string name, string job ,int xp, int level)
        {
            _name = name;
            _job = job;
            _xp = xp;
            _level = level;

        }

        public override void Fight(Entity[] targets)
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



