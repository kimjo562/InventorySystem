using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Map
    {
        private int _currentLocation = 0;                                                   // ID of the current scene
        private Scene[] _sceneList;                                                         // List of all the scens on the map

        public Map(int startingSceneID, Scene[] scenes)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;

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
    }
}