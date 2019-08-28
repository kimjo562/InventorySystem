using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Encounter
    {
        private Monster[] _goodMonster;
        private Monster[] _badMonster;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _goodMonster = team1;
            _badMonster = team2;


        }

        public void Print()
        {   // Iterate each monsters and Print
            for (int i = 0; i < _goodMonster.Length; i++)                   //Starts and 0 and checks whats in slot one, then increments by 1, once it hits the middle condition, it will stop.
            {
                Monster currentMonster = _goodMonster[i];
                currentMonster.Print();
                
            }
            Console.WriteLine();
            for (int i = 0; i < _badMonster.Length; i++)                   //Starts and 0 and checks whats in slot one, then increments by 1, once it hits the middle condition, it will stop.
            {
                Monster currentMonster = _badMonster[i];
                currentMonster.Print();

            }

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
    }
}
