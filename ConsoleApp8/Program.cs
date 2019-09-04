using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0: Courtyard
            // 1: Castle Gate
            // 2: Graveyard
            // 3: Village
//                                                          N   S   E   W                                               
            Scene courtyard = new Scene("Courtyard",        1,  3, -1,  2, "The hub area intersecting between three main areas of the town. It has a fountain at the center of it and its very open and wide with a paved road covering the ground.\nThere is way North, South, and West of here.");
            Scene castleGate = new Scene("Castle Gate",    -1,  0, -1, -1, "You approach a large gate which acts as the entry way to the castle, fortifed with steel bars and a couple of guards hanging around the sides.\nThere is an exit to the south.");
            Scene graveyard = new Scene("Graveyard",       -1, -1,  0, -1, "Upon entering, you feel a chill going down your spine, an uneasy feeling wells up inside you. You see in front of you several graves, mostly of previous kings and queens, and some formally well known knights and soliders who laid their life of the country. Nonetheless, you pay respects.\nThere is an exit to the north and east");
            Scene village = new Scene("Village",            0, -1,  1, -1, "You spot a small village as you walk by, further inspection show its a fairly small community mostly made up of shopkeepers and blacksmiths, and couple of shops located nearby.\nThere is an exit *Blank and *Blank*");

            // Has to be placed in an order within the array if you want it to work correctly (ORDER MATTERS)
            Scene[] scenes = { courtyard, castleGate, graveyard, village };
            Map map = new Map(0, scenes);

            map.PrintCurrentScene();
            map.CurrentSceneID = 1;
            map.PrintCurrentScene();
            map.CurrentSceneID = 2;
            map.PrintCurrentScene();
            map.CurrentSceneID = 3;
            map.PrintCurrentScene();
           

            Console.ReadKey();



                return;


/*
            int totalDamage = + Name.GetDamage();
            Console.Write("You do a total for: " + Name.GetDamage());

            Console.ReadKey();
*/



            // Created a Bunch of Monsters
            Entity slime = new Monster("Slime", 50, 10);
            Entity rat = new Monster("Rat", 25, 5);
            Entity zombie = new Monster("Zombie", 30, 15);
            Entity skeleton = new Monster("Skeleton", 35, 10);
            Character myself = new Knight("Player");                                            // Knight already has its own stats, so don't make one.

            // Create two arrays and palce the monsters into them
            Entity[] goodTeam = { myself, rat, slime };
            Entity[] badTeam = { zombie, skeleton };

            //Create an enoutner for the two arrays of monsters
            Encounter encounter = new Encounter(goodTeam, badTeam);
            encounter.Print();

            encounter.BeginRound();
            encounter.Start();
            encounter.Print();

            myself.openInventory();

            Console.ReadKey();



            return;


            //     Inventory inventory = new Inventory();
            //     inventory.Menu();
            string name = "";
            string choice = "";

            Console.Write("Enter the name of Party Member 1: ");
            name = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Choose a Job");
                Console.WriteLine("---------------");
                Console.WriteLine("1.) Knight");
                Console.WriteLine("2.) Hunter");
                Console.WriteLine("3.) Wizard");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
            Character player;
            if (choice == "1")
            {
                player = new Knight(name);                                                    // This will pass the string Knight from Character Class.

            }
            else if (choice == "2")
            {
                player = new Hunter(name);                                                    // This will pass the string Hunter from Character Class.

            }
            else if (choice == "3")
            {
                player = new Wizard(name);                                                    // This will pass the string Wizard from Character Class.

            }
            else
            {
                player = new Character(name);
            }

            Knight yeetman = new Knight("Yeetman");
            Wizard justyes = new Wizard("Yes");


            choice = "";
            while (choice != "0")
            {
                Console.WriteLine("Whose inventory?");
                Console.WriteLine("---------------");
                Console.WriteLine("1.) " + player.GetName());
                Console.WriteLine("2.) " + justyes.GetName());
                Console.WriteLine("3.) " + yeetman.GetName());
                Console.WriteLine("0.) Exit");
                choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    player.Print();
                    player.openInventory();

                }
                else if (choice == "2")
                {
                    justyes.Print();
                    justyes.openInventory();

                }
                else if (choice == "3")
                {
                    yeetman.Print();
                    yeetman.openInventory();

                }
            }

            player.Experience = 25;
            player.Experience = player.Experience + 250;                                             // Examples of the different ways to add Experience.
            player.Experience += 75;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;


            int[] testArray = new int[4];                                                           // Arrays start at 0(slot)
            testArray[0] = 1;                                                                       // Refers to whatever slot 0 is.   (So Slot 0 = 1)
            testArray[1] = 3;                                                                       // Slot 1  =  3
            testArray[2] = 5;                                                                       // Slot 2  =  5
            testArray[3] = 7;                                                                       // Slot 3  =  7

            int[] testArray2 = { 2, 4, 6, 8 };                                                      // Set array size by naming variable.
            string[] stringArray = new string[3];

            Character[] party = { player, justyes, yeetman, new Character("Memer") };               // Memer can only be used through an array.


            Console.ReadKey();


        }
    }
}
