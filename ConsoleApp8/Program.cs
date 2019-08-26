using ConsoleApp8;
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
            //     Inventory inventory = new Inventory();
            //     inventory.Menu();


            Character player = new Character("OiBoi");
            Console.WriteLine("Hello " + player.Name()+ ", you need to find something.\n");
            player.Print();

            Character yeetman = new Character("Yeetman");
            Character justyes = new Character("Yes");
            Console.WriteLine(" \n");
            justyes.Print();
            Console.WriteLine(" \n");
            yeetman.Print();


            player.Experience = 25;
            player.Experience = player.Experience + 250;                                             // Examples of the different ways to add Experience.
            player.Experience += 75;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
            player.Experience += 150;
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
