﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        float gold = 0.00f;
        int _itemDamage = 5;                                                       // Automatically makes it private if not declared (int damage = 5;  also == private int damage =5;)
        int currentDamage = 5;
        int _itemDefense = 0;
        int currentDefense = 0;
        int _weaponWeight = 0;
        int _armorWeight = 0;
        int _potionWeight = 0;
        int _inventoryWeight = 0;
        int _maxInventoryWeight = 50;
        int _potionHeld = 0;
        private AttackItem[] _weaponList = new AttackItem[10];                      // [10] Inventory Limit
        private DefenseItem[] _armorList = new DefenseItem[10];                     // [10] Inventory Limit

        public Inventory()
        {
            //Populate the weapon list

            _weaponList[0] = new AttackItem("Great Sword", 75, 35);
            _weaponList[1] = new AttackItem("Sword", 25, 10);
            _weaponList[2] = new AttackItem("Dagger", 20, 5);
            _weaponList[3] = new AttackItem("Spear", 30, 15);
            _weaponList[4] = new AttackItem("Bow", 25, 10);

            //Populate the armor list
            _armorList[0] = new DefenseItem("Leather Armor", 10, 10);
            _armorList[1] = new DefenseItem("Chain Armor", 25, 10);
            _armorList[2] = new DefenseItem("Iron Armor", 20, 5);
            _armorList[3] = new DefenseItem("Cloth Armor", 30, 15);

    }

        public int ItemDamage()                                                                                   // Returns the damage our weapons deals.
        {
            return _itemDamage;

        }
        public int ItemDefense()                                                                                  // Returns the damage our armor grants.
        {
            return _itemDefense;

        }

        public void Menu()
        {
            string choice = "";
            while (choice != "Q")
            {
                // Display Menu
                Console.WriteLine("Inventory Menu");
                Console.WriteLine("Money: " + gold + "    Weapon Damage: " + currentDamage + "    Armor Defense: " + currentDefense + "    Weight: " + _inventoryWeight + " / " + _maxInventoryWeight + "    Potions Held: " + _potionHeld);
                Console.WriteLine("1.) Equip Gear \n2.) Unequip Gear \n3.) Add Gold \n4.) Remove Gold \n5.) Shop \n6.) Drink Potion \nQ.) Quit");

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
                    if (choice == "1")
                    {
                        Console.WriteLine("Here are your weapon choices.");
                        Console.WriteLine("1.) Great Sword    2.) Sword    3.) Dagger    4.) Spear    5.) Bow    0.) Back");
                        subChoice = Console.ReadLine();

                        EquipWeapon(subChoice);

                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Here are your armor choices.");
                        Console.WriteLine("1.) Leather    2.) Chain    3.) Iron   4.) Cloth    0.) Back");
                        subChoice = Console.ReadLine();

                        EquipArmor(subChoice);

                    }
                    else if (choice != "0")
                    {


                    }

                }
                else if (choice == "2")
                {
                    string subChoice = "";
                    Console.WriteLine("What would you like to remove?");
                    Console.WriteLine("1.) Weapon    2.) Armor    0.)Back");
                    choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        UnequipWeapon();
                    }
                    else if (choice == "2")
                    {
                        UnequipArmor();
                    }
                    else if (choice != "0")
                    {


                    }


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
                else if (choice == "5")
                {
                    Shop(choice);
                }
                else if (choice == "6")
                {
                    if (_potionHeld <= 0)
                    {
                        Console.WriteLine("Are you trying to drink nothing? Are you dumb?\n");
                    }
                    else
                    {
                        Console.WriteLine("You drank one potion... it did nothing.\n");
                        _potionHeld -= 1;
                        _inventoryWeight -= 2;
                    }

                }
            }


        }

        public void EquipWeapon(string subChoice)
        {
            if (subChoice == "1")
            {
                _itemDamage = _weaponList[0].Damage;
                _weaponWeight = _weaponList[0].Weight;
                WeaponWeightFix();                                                           // Makes it so Weight doesn't stack or lose with other equipment weights.

                if (_inventoryWeight > _maxInventoryWeight)                                    // If Weight exceeds max, revert
                {
                    WeightExceedWeapon();
                }
                else
                {
                    Console.WriteLine("You have spawned in the Great Sword.");
                }
            }
            else if (subChoice == "2")
            {
                _itemDamage = _weaponList[1].Damage;
                _weaponWeight = _weaponList[1].Weight;
                WeaponWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedWeapon();
                }
                else
                {
                    Console.WriteLine("You have spawned in the Sword.");
                }
            }
            else if (subChoice == "3")
            {
                _itemDamage = _weaponList[2].Damage;
                _weaponWeight = _weaponList[2].Weight;
                WeaponWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedWeapon();
                }
                else
                {
                    Console.WriteLine("You have spawned in the Dagger");
                }
            }
            else if (subChoice == "4")
            {
                _itemDamage = _weaponList[3].Damage;
                _weaponWeight = _weaponList[3].Weight;
                WeaponWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedWeapon();
                }
                else
                {
                    Console.WriteLine("You have spawned in the Spear.");
                }
            }
            else if (subChoice == "5")
            {
                _itemDamage = _weaponList[4].Damage;
                _weaponWeight = _weaponList[4].Weight;
                WeaponWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedWeapon();
                }
                else
                {
                    Console.WriteLine("You have spawned in the Bow.");
                }
            }
            else if (subChoice != "0")
            {
                EquipWeapon(subChoice);

            }
            Console.WriteLine("Your current weapon does " + currentDamage + " damage.\n");

        }

        public void EquipArmor(string subChoice)
        {
            if (subChoice == "1")
            {
                _itemDefense = _armorList[0].Defense;
                _armorWeight = _armorList[0].Weight;
                ArmorWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedArmor();
                }
                else
                {
                    Console.WriteLine("You have equipped the Leather Armor.");
                }
            }
            else if (subChoice == "2")
            {
                _itemDefense = _armorList[1].Defense;
                _armorWeight = _armorList[1].Weight;
                ArmorWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedArmor();
                }
                else
                {
                    Console.WriteLine("You have equipped the Chain Armor.");
                }
            }
            else if (subChoice == "3")
            {
                _itemDefense = _armorList[2].Defense;
                _armorWeight = _armorList[2].Weight;
                ArmorWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedArmor();
                }
                else
                {
                    Console.WriteLine("You have equipped the Iron Armor.");
                }
            }
            else if (subChoice == "4")
            {
                _itemDefense = _armorList[3].Defense;
                _armorWeight = _armorList[3].Weight;
                ArmorWeightFix();

                if (_inventoryWeight > _maxInventoryWeight)
                {
                    WeightExceedArmor();
                }
                else
                {
                    Console.WriteLine("You have equipped the Cloth Armor.");
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

            if (currentDamage == 5)
            {
                Console.WriteLine("You can't delete something you don't even have!\n");

            }
            else
            {
                Console.WriteLine("You deleted your weapon.");
                currentDamage = 5;
                _weaponWeight = 0;
                _inventoryWeight = 0;

                _inventoryWeight += _weaponWeight;
                _inventoryWeight += _armorWeight;
                Console.WriteLine("You have no weapon, you do " + currentDamage + " damage.\n");

            }

        }

        public void UnequipArmor()
        {
            currentDefense = 0;
            _armorWeight = 0;
            _inventoryWeight = 0;

            _inventoryWeight += _armorWeight;
            _inventoryWeight += _weaponWeight;
            Console.WriteLine("You have no armor, you have " + currentDefense + " armor.\n");

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

        public void WeaponWeightFix()
        {
            currentDamage = 0;
            currentDamage += _itemDamage;
            _inventoryWeight = 0;
            _inventoryWeight += _potionWeight;
            _inventoryWeight += _armorWeight;
            _inventoryWeight += _weaponWeight;
        }

        public void ArmorWeightFix()
        {
            currentDefense = 0;
            currentDefense += _itemDefense;
            _inventoryWeight = 0;
            _inventoryWeight += _potionWeight;
            _inventoryWeight += _weaponWeight;
            _inventoryWeight += _armorWeight;
        }

        public void WeightExceedArmor()
        {
            Console.WriteLine("This would exceed your max carry limit!");
            Console.WriteLine("You unequipped your armor.");
            _inventoryWeight -= _armorWeight;
            currentDefense -= _itemDefense;
        }
        public void WeightExceedWeapon()
        {
            Console.WriteLine("This would exceed your max carry limit!");
            Console.WriteLine("You unequipped your weapon.");
            _inventoryWeight -= _weaponWeight;
            currentDamage -= _itemDamage;
        }

        public void Shop(string choice)
        {
            Console.WriteLine("Welcome to the SHOP (Supposedly Haggling Obnoxious Players)");
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("1.) Potion \n2.) *Null* \n3.) *Null* \n0.) Back");
            choice = Console.ReadLine();

            if (choice == "1")
            {

                if (choice == "1")
                {
                    Console.WriteLine("How many would you like to buy?");
                    int potionAmount = Convert.ToInt32(Console.ReadLine());

                    if (gold > 250 * potionAmount)
                    {
                        gold -= 250 * potionAmount;                                     // How many you want to buy = respective price.
                        _potionWeight = potionAmount *2;
                        _inventoryWeight += _potionWeight;

                        if (_inventoryWeight > _maxInventoryWeight)
                        {
                            Console.WriteLine("This would exceed your max carry limit! So you throw the potion away. (What a waste of money.)\n");
                            _inventoryWeight -= _potionWeight;
                        }
                        else
                        {
                            Console.WriteLine("You have bought " + potionAmount + " and it costed you " + potionAmount * 250 + " gold.\n");
                            _potionHeld += potionAmount;
                        }

                    }
                    else if (gold < 250 * potionAmount)
                    {
                        Console.WriteLine("You're short on gold you pleb.");
                        Console.WriteLine("Git out of mah shop.\n");
                        Console.ReadKey();

                    }

                }

            }
            else if(choice == "2")
            {


            }
            else if(choice == "3")
            {


            }
            else if(choice != "0")
            {
                // Go back to the Main Menu
            }
        }

    }
}

