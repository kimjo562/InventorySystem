using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Monster : Entity
    {
        private string _name = "";
        private int _damage = 10;
        private int _defense = 5;


        public Monster(string name, int health, int damage, int defense, int experience)                                     // This is a constructor and can be used interchangably with other variables.
        {
            _name = name;
            _maxHealth = health;
            _health = health;
            _damage = damage;
            _defense = defense;
            _xp = experience;
        }

        public override string GetName()
        {
            return _name;

        }
        public override int GetDamage()
        {
            return _damage;
 
        }

        public override int GetDefense()
        {
            return _defense;
        }

        public override int GetXP()
        {
            return _xp;
        }

        public override void Print()
        {
            Console.WriteLine("Monster: " + _name);
            Console.WriteLine("Health: "+ _health + " / " + _maxHealth);
            Console.WriteLine("Combat Damage: " +_damage);
            Console.WriteLine("Combat Defense: " +_defense);
            Console.WriteLine();
        }



        public override void Fight(Entity target)
        {
            if(Health <= 0)
            { 
                return;
            }

            int damage = GetDamage();
            int defense = GetDefense();
            //target's health - this monster's damage
            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " takes " + damage + " damage, but blocked by " + target.GetDefense() + " armor.");
            // Subtracts the damage from the target monster's health
            damage -= target.GetDefense();
            target.Health -= damage;
            Console.WriteLine(target.GetName() + " has " + target.Health + " health.\n");

        }

        public override void Fight(Entity[] targets)
        {
            if (Health <= 0)
            {
                return;
            }


            int choice = Program.random.Next(0, targets.Length);                                   // Randomly picks a number from 0 - The amount of enemies being fought.
            Fight(targets[choice]);

            /*
            bool validInput = false;
            while(!validInput)
            {
                int choice = 0;
                Console.WriteLine("\nWho will " + GetName() + " fight? ");
                for (int i = 0; i < targets.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + targets[i].GetName());

                }
                choice = Convert.ToInt32(Console.ReadLine());               // Grab Input

                if(choice >= 0 && choice <= targets.Length)
                {
                    validInput = true;
                    //Fight the Chosen Target
                    Console.WriteLine("\nFight " + targets[choice - 1].GetName());                  //checking if it works
                    Console.WriteLine();
                    Fight(targets[choice - 1]);
                }
            }
            */
        }
    }
}
