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
        int currentDamage = 5;
        int defense = 0;
        int currentDefense = 0;
        int weaponWeight = 0;
        int armorWeight = 0;
        int inventoryWeight = 0;
        int maxInventoryWeight = 50;

        public void Menu()
        {
            string choice = "";



            while (choice != "Q")
            {
                // Display Menu
                Console.WriteLine("Inventory Menu");
                Console.WriteLine("Money: " + gold + "    Weapon Damage: " + currentDamage + "    Armor Defense: " + currentDefense + "    Weight: " +inventoryWeight);
                Console.WriteLine("1.) Equip Weapon    2.) Unequip Weapon   3.) Add Gold    4.) Remove Gold    Q.) Quit");

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
                        Console.WriteLine("Here are your armor choices.");
                        Console.WriteLine("1.) Leather    2.) Chain    3.) Iron   4.) Cloth    0.) Back");
                        subChoice = Console.ReadLine();

                        EquipArmor(subChoice);

                    }
                    else if(choice != "0")
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
                weaponWeight = 35;

                currentDamage = 0;
                currentDamage += damage;
                inventoryWeight = 0;                                        // Resets Weight and doesn't stack with current armor Weight 
                inventoryWeight += armorWeight;
                inventoryWeight += weaponWeight;

                if(inventoryWeight > maxInventoryWeight)                    // If Weight exceeds max
                {
                    Console.WriteLine("This would exceed your max carry limit!");           
                    inventoryWeight -= weaponWeight;                        // Reverts changes
                    currentDamage -= damage;
                }
            }
            else if (subChoice == "2")
            {
                Console.WriteLine("You have spawned in the Sword.");
                damage = 25;
                weaponWeight = 10;

                currentDamage = 0;
                currentDamage += damage;
                inventoryWeight = 0;                                      
                inventoryWeight += armorWeight;
                inventoryWeight += weaponWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= weaponWeight;
                    currentDamage -= damage;
                }
            }
            else if (subChoice == "3")
            {
                Console.WriteLine("You have spawned in the Dagger");
                damage = 20;
                weaponWeight = 5;

                currentDamage = 0;
                currentDamage += damage;
                inventoryWeight = 0;                                       
                inventoryWeight += armorWeight;
                inventoryWeight += weaponWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= weaponWeight;
                    currentDamage -= damage;
                }
            }
            else if (subChoice == "4")
            {
                Console.WriteLine("You have spawned in the Spear.");
                damage = 30;
                weaponWeight = 15;

                currentDamage = 0;
                currentDamage += damage;
                inventoryWeight = 0;                                     
                inventoryWeight += armorWeight;
                inventoryWeight += weaponWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= weaponWeight;
                    currentDamage -= damage;
                }
            }
            else if (subChoice == "5")
            {
                Console.WriteLine("You have spawned in the Bow.");
                damage = 25;
                weaponWeight = 10;

                currentDamage = 0;
                currentDamage += damage;
                inventoryWeight = 0;                                       
                inventoryWeight += armorWeight;
                inventoryWeight += weaponWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= weaponWeight;
                    currentDamage -= damage;
                }
            }
            else if(subChoice != "0")
            {
                EquipWeapon(subChoice);

            }
            Console.WriteLine("Your current weapon does " + currentDamage + " damage.\n");

        } 

        public void EquipArmor(string subChoice)
        {
            if (subChoice == "1")
            {
                Console.WriteLine("You have equipped the Leather Armor.");
                defense = 10;
                armorWeight = 10;

                currentDefense = 0;
                currentDefense += defense;
                inventoryWeight = 0;                                        
                inventoryWeight += weaponWeight;
                inventoryWeight += armorWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= armorWeight;
                    currentDefense -= defense;
                }
            }
            else if (subChoice == "2")
            {
                Console.WriteLine("You have equipped the Chain Armor.");
                defense = 15;
                armorWeight = 15;

                currentDefense = 0;
                currentDefense += defense;
                inventoryWeight = 0;                                        
                inventoryWeight += weaponWeight;
                inventoryWeight += armorWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= armorWeight;
                    currentDefense -= defense;
                }
            }
            else if (subChoice == "3")
            {
                Console.WriteLine("You have equipped the Iron Armor.");
                defense = 20;
                armorWeight = 20;

                currentDefense = 0;
                currentDefense += defense;
                inventoryWeight = 0;                                        
                inventoryWeight += weaponWeight;
                inventoryWeight += armorWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= armorWeight;
                    currentDefense -= defense;
                }
            }
            else if (subChoice == "4")
            {
                Console.WriteLine("You have equipped the Cloth Armor.");
                defense = 5;
                armorWeight = 5;

                currentDefense = 0;
                currentDefense += defense;
                inventoryWeight = 0;                                        
                inventoryWeight += weaponWeight;
                inventoryWeight += armorWeight;

                if (inventoryWeight > maxInventoryWeight)
                {
                    Console.WriteLine("This would exceed your max carry limit!");
                    inventoryWeight -= armorWeight;
                    currentDefense -= defense;
                }
            }
            else if (subChoice != "0")
            {
                EquipWeapon(subChoice);

            }
            Console.WriteLine("Your current armor yields " + currentDefense + " defense.\n");



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
                weaponWeight = 0;
                Console.WriteLine("You have no weapon, you do " + currentDamage + " damage.\n");

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
