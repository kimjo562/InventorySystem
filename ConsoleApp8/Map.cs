using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                                                                            // Allows Save() and Load() to work.

namespace InventorySystem
{
    class Map
    {
        private int _currentLocation = 0;                                                   // ID of the current scene
        private Scene[] _sceneList;                                                         // List of all the scenes on the map
        private Entity[] _players;
        private Entity player = new Character("", "");

        public Map(int startingSceneID, Scene[] scenes, Entity[] players)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
            _players = players;
        }

        public void PrintCurrentScene()
        {
            // If the current Scene ID is within range.
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //Print the current scene's name and description
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
                _sceneList[_currentLocation].cordCheck();

            }
            else
            {
                Console.WriteLine("\nError, Scene (ID) not found.");
            }

        }

        public int CurrentSceneID
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                // Checks the value assigned is in range first
                if (value >= 0 && value < _sceneList.Length)
                {
                    //Changes to the new scene
                    _currentLocation = value;

                }
                else
                {
                    //Otherwise, print an error.
                    Console.WriteLine("\nError, Scene (ID) not found.");
                }
            }

        }

        public void Menu()
        {
            string choice = "";
            while(choice != "0")
            {
                PrintCurrentScene();                                                                            // Lets the player know where they're currently at.
                
                Console.WriteLine("\nMenu:");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1.) Travel ");
                Console.WriteLine("2.) Search");
                Console.WriteLine("3.) Save");
                Console.WriteLine("4.) Load");
                Console.WriteLine("5.) Inventory");
                Console.WriteLine("0.) Exit");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Travel();                  

                }
                else if (choice == "2")
                {
                    Search();
                }
                else if (choice == "3") 
                {
                    Save("SaveFile.txt");
                    Console.WriteLine("Location Saved.");
                }
                else if (choice == "4")
                {
                    Load("SaveFile.txt");
                    Console.WriteLine("Reloaded Save.");

                }
                else if (choice == "5")
                {
                    Console.WriteLine("Whose inventory do you want to open?");
                    for (int i = 0; i < _players.Length; i++)
                    {
                        player = _players[i];
                        Console.WriteLine((i + 1)+ ".) " + player.GetName());                  
                    }
                    int subchoice = Convert.ToInt32(Console.ReadLine());
                    player = _players[subchoice-1];
                    Console.WriteLine("");
                    player.openInventory();


                }
            }

        }

        public void Travel()
        {
            int destination = -1;                                                                               // Default
            // If the current scene is valid. 
            if(_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                // Ask where the player where to go.
                destination = _sceneList[_currentLocation].ChooseExit();
            }
            // If the destination is on the map...
            if(destination >=0 && destination < _sceneList.Length)
            {
                // Go there
                CurrentSceneID = destination;
            }
            else
            {
                // Otherwise, Tell the player they cannot go there.
                Console.WriteLine("There is nothing in that direction");

            }
            CheckForEntities();
        }

        public void Search()
        {
            // If the current scene is valid. 
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                // Search the Room
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }


        }

        public void CheckForEntities()
        {
            // If the current scene is valid. 
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Scene currentScene = _sceneList[_currentLocation];
                if (currentScene.GetCleared() == false)
                {
                    // Fight
                    Encounter encounter = new Encounter(_players, currentScene.GetEnemies());
                    encounter.Start();
                }

            }

        }
        
        public void Save(string path)
        {
            // Creates a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            // Write to it the same way we write                                                                   (Saving at different places will overwrite old one)
            writer.WriteLine(CurrentSceneID);
            writer.WriteLine(_players.Length);                                                                     // Party Size
            for(int i = 0; i < _players.Length; i++)
            {
                player = _players[i];               
                writer.WriteLine(player.GetName());                                                                // All Party Member's names
                writer.WriteLine(player.GetJob());                                                                 // All Party Member's Jobs
                writer.WriteLine(player.GetLevel());                                                               // All Party Member's Level
                writer.WriteLine(player.GetXP());                                                                  // All Party Member's in Order XP Values
            }

            writer.Close();
        }

        public void Load(string path)
        {
            if(File.Exists(path))                                                                                  // Checks if the file even exists before it loads.
            {
                // Create a reader object for the file at our path
                StreamReader reader = File.OpenText(path);
                // Write to it the same way we read from console.
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                int partySize = Convert.ToInt32(reader.ReadLine());
                for(int i = 0; i < partySize; i++)
                {                

                    string name = (reader.ReadLine());
                    string job = (reader.ReadLine());
                    int xp = Convert.ToInt32(reader.ReadLine());
                    int level = Convert.ToInt32(reader.ReadLine());
                    player.Load(name, job, xp, level);
                    _players[i] = player;
                }

                // Close it
                reader.Close();

            }
            else
            {
                Console.WriteLine("Save File not found.");
            }

        }



    }
}