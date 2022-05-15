using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class GameCharacter
    {
        // Properties for hero and boss
        public int Health;
        public int Strength;
        public int Stamina;
        //private int _MaxStamina;

        // Constructor 
        public GameCharacter(int aHealth, int aStrength, int aStamina) // <-- This is the constructor with parameters. "a" for Arguments
        {
            Health = aHealth;
            Strength = aStrength;
            Stamina = aStamina;
        }

        // Methods
        public void Fight(int aStrength)
        {
            if (Stamina == 0)
            {
                Console.WriteLine("Out of stamina!!");
                
            }
        }

    }
}
