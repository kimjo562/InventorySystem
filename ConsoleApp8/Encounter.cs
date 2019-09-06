using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Encounter
    {
        private Entity[] _goodMonster;                                                  
        private Entity[] _badMonster;                                                   

        public Encounter(Entity[] team1, Entity[] team2)
        {
            _goodMonster = team1;
            _badMonster = team2;

        }

        public void Print()
        {   // Iterate each monsters and Print
            for (int i = 0; i < _goodMonster.Length; i++)                   //Starts and 0 and checks whats in slot one, then increments by 1, once it hits the middle condition, it will stop.
            {
                Entity currentMonster = _goodMonster[i];
                currentMonster.Print();
                
            }
            Console.WriteLine();
            for (int i = 0; i < _badMonster.Length; i++)                   //Starts and 0 and checks whats in slot one, then increments by 1, once it hits the middle condition, it will stop.
            {
                Entity currentMonster = _badMonster[i];
                currentMonster.Print();

            }

        }
        // Return the total XP of all the creatures on one team
        public int GetTotalXP(Entity[] entities)
        {
            int total = 0;
            for (int i = 0; i < entities.Length; i++)
            {
                total += entities[i].GetXP();
            }

            return total;
        }

        public void BeginRound()
        {
            //Iterate through good monsters
            //Have the current good monster fight bad first
            for (int i = 0; i < _goodMonster.Length; i++)                
            {
                _goodMonster[i].Fight(_badMonster);

            }

            for (int i = 0; i < _badMonster.Length; i++)                   //Starts and 0 and checks whats in slot one, then increments by 1, once it hits the middle condition, it will stop.
            {
                _badMonster[i].Fight(_goodMonster);

            }

        }

        public void Start()
        {
            Console.WriteLine("\nEncounter Start.");
            bool stillFighting = true;
            while(stillFighting)
            {
                //check if team 1 is alive
                bool team1Alive = false;
                for (int i = 0; i < _goodMonster.Length ; i++)
                {
                    Entity currentMonster = _goodMonster[i];
                    if(currentMonster.Health > 0)
                    {
                        team1Alive = true;
                        break;
                    }
                    else if (currentMonster.Health <=0)
                    {
                        team1Alive = false;
                    }
                }
                //check if team 2 is alive
                bool team2Alive = false;
                for (int i = 0; i < _badMonster.Length; i++)
                {
                    Entity currentMonster = _badMonster[i];
                    if (currentMonster.Health > 0)
                    {
                        team2Alive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        team2Alive = false;
                    }
                }
                //if both teams are alive
                if (team1Alive && team2Alive)
                {
                    //fight
                    stillFighting = true;
                    BeginRound();
                }             
                else
                {
                    //stop
                    stillFighting = false;

                    if(team1Alive)
                    {   //Gives XP to each Character in Team 1
                        foreach (Entity cr in _goodMonster)
                        {
                            if(cr is Character)
                            {
                                Character ch = (Character)cr;
                                ch.Experience += GetTotalXP(_badMonster);
                            }
                            Console.ReadKey();
                        }

                    }
                    else if(team2Alive)
                    {   //Gives XP to each Character in Team 2
                        foreach (Entity cr in _badMonster)
                        {
                            if (cr is Character)
                            {
                                Character ch = (Character)cr;
                                ch.Experience += GetTotalXP(_goodMonster);
                            }

                        }
                    }

                }
                Print();
            }

        }

    }
}
