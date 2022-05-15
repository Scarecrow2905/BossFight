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

        var Hero = new GameCharacter(100, 20, 40); // <-- The stats of the hero: Health = 100, Strength = 20 and Stamina = 40
        var Boss = new GameCharacter(400, 0 - 30, 10); // <-- The stats of the boss: Health = 400, Strength = (random0, 30) and Stamina = 10
        

        Console.WriteLine("Hero health: " + Hero.Health);
        Console.WriteLine("Boss health: " + Boss.Health);
        Console.ReadLine();
    }

}