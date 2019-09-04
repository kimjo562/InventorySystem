using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Scene
    {
        private string _name = "";
        private string _description = "";
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private string _hidden;
        
        public Scene(string name, int northID, int southID, int eastID, int westID, string description)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = "You found nothing.";

        }

        public Scene(string name, int northID, int southID, int eastID, int westID, string description, string hidden)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = hidden;
        }

        // Returns the Name
        public string GetName()
        {

            return _name;
        }

        // Returns the description
        public string GetDescription()
        {
            return _description;
        }

        public int ChooseExit()
        {

            // Until the player chooses a direction
            string choice = "";
            while(choice != "n" && choice != "s" && choice != "e" && choice != "w")
            {
                Console.WriteLine("Which direction would you like to go?");
                Console.WriteLine("Use N/S/E/W");
                choice = Console.ReadLine();
                choice = choice.ToUpper();                                                                                      // Set choice to caps (regardless if they use lower cases)
                                                                                                                                //              choice = choice.ToLower();                                                                                    <--- Same thing except sets lower case (regardless if they use Upper Case)

                if (choice == "N")
                {
                    return _north;
                }
                else if (choice == "S")
                {
                    return _south;
                }
                else if (choice == "E")
                {
                    return _east;
                }
                else if (choice == "W")
                {
                    return _west;
                }
                else
                {
                    return -1;                                                                                                  // If somehow we have an invalid choice, we can return -1;
                }                                                                                                               // We have to make sure the map knows not to attempt to travel to -1;
            }
            // Return the integer ID of that direction
            return -1;                                                                                                          // -1 is like a map boundary.
        }

        public int cordCheck()
        {
            Console.Write(_north.ToString() + " ");
            Console.Write(_south.ToString() + " ");
            Console.Write(_east.ToString() + " ");
            Console.Write(_west.ToString() + " ");
            return 0;
        }

        public string GetHidden()
        {
            return _hidden;

        }

    }
        
}

