using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight;

internal class Program
{
    static void Main(string[] args)
    {

        Random bStrength = new Random();

        var Hero = new GameCharacter("Hero", 120, 24, 40); // <-- The stats of the hero: Health = 100, Strength = 20 and Stamina = 40
        var Boss = new GameCharacter("Boss", 300, 30, 10); // <-- The stats of the boss: Health = 400, Strength = (random0, 30) and Stamina = 10


        bool currentPlayer = true;

        while (Hero.Health > 0 && Boss.Health > 0)
        {
           var activePlayer = currentPlayer ? Hero : Boss; 
           var inactivePlayer  = !currentPlayer ? Hero : Boss;
           var damage = activePlayer == Hero ? activePlayer.Strength : bStrength.Next(0, Boss.Strength + 1) ;

           Console.WriteLine(activePlayer.Fight(damage, inactivePlayer) ? 
               $"{activePlayer.Name} hit {inactivePlayer.Name} for {damage} damage! {inactivePlayer.Name} has {inactivePlayer.Health}hp left" :
               $"{activePlayer.Name} recharged"
               );

            currentPlayer = !currentPlayer;

            Console.ReadKey();

        }

        Console.WriteLine(!currentPlayer ? "The hero won the fight!" : "The boss won the fight!");

    }

}