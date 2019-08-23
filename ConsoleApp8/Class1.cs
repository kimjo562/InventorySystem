using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Inventory
    {
        float gold = 0.00f;
        int damage = 5;

        public void Menu()
        {
            string choice = "";



            while (choice != "0")
            {
                // Display Menu
                Console.WriteLine("Inventory Menu");
                Console.WriteLine("Current Money: " + gold);
                Console.WriteLine("1.) Equip Weapon    2.) Unequip Weapon   3.) Add Gold    4.) Remove Gold    0.) Exit");

                //Get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //Check Input
                if (choice == "1")
                {
                    string subChoice = "";
                    Console.WriteLine("What would you like to change?");
                    Console.WriteLine("1.) Weapon    2.) Armor    0.)Back");
                    choice = Console.ReadLine();
                    if(choice == "1")
                    {
                        Console.WriteLine("Here are your weapon choices.");
                        Console.WriteLine("1.) Great Sword    2.) Sword    3.) Dagger    4.) Spear    5.) Bow    0.) Back");
                        subChoice = Console.ReadLine();

                        EquipWeapon(subChoice);

                    }
                    else if(choice == "2")
                    {


                    }

                }
                else if (choice == "2")
                {
                    UnequipWeapon();

                }
                else if (choice == "3")
                {
                    Console.WriteLine("How much gold do you want to cheat in?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);

                }
                else if (choice == "4")
                {
                    Console.WriteLine("How much gold do you want to yeet?");
                    float removedGold = Convert.ToSingle(Console.ReadLine());
                    RemoveGold(removedGold);

                }

            }


        }

        public void EquipWeapon(string subChoice)
        {
            if (subChoice == "1")
            {
                Console.WriteLine("You have spawned in the Great Sword.");
                damage = 75;
            }
            else if (subChoice == "2")
            {
                Console.WriteLine("You have spawned in the Sword.");
                damage = 25;
            }
            else if (subChoice == "3")
            {
                Console.WriteLine("You have spawned in the Dagger");
                damage = 20;
            }
            else if (subChoice == "4")
            {
                Console.WriteLine("You have spawned in the Spear.");
                damage = 30;
            }
            else if (subChoice == "5")
            {
                Console.WriteLine("You have spawned in the Bow.");
                damage = 25;
            }
            Console.WriteLine("Your current weapon does " + damage + " damage.\n");

        } 


        public void UnequipWeapon()
        {
            if (damage == 5)
            {
                Console.WriteLine("You can't delete something you don't even have!\n");

            }
            else
            {
                Console.WriteLine("You deleted your weapon.");
                damage = 5;
                Console.WriteLine("You have no weapon, you do " + damage + " damage.\n");

            }

        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold.\n");
            gold += amount;

        }

        public void RemoveGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold.\n");
            gold -= amount;

            if (gold < amount)
            {
                gold = 0;
            }

        }
    }
}
