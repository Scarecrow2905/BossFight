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
        public string Name;
        public int Health;
        public int Strength;
        public int Stamina;
        private int _MaxStamina;

        // Constructor 
        public GameCharacter(string aName, int aHealth, int aStrength, int aStamina) // <-- This is the constructor with parameters. "a" for Arguments
        {
            Name = aName;
            Health = aHealth;
            Strength = aStrength;
            Stamina = aStamina;
            _MaxStamina = aStamina;
        }

        // Methods
        public bool Fight(int dmg, GameCharacter opponent)
        {
            if (Stamina == 0)
            {
                Recharge();
                return false;
                
            }

            if (opponent.Health - dmg < 0)
            {
                opponent.Health = 0;
            }
            else opponent.Health -= dmg;
            
            
            Stamina -= 10;
            return true;

        }

        public void Recharge()
        {
            Stamina = _MaxStamina;
        }

    }
}
