using MyProperCSharpJourney.Exersise_work.WarHammers.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.WarHammers;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public static class Tyranid1Attacks
    {
        private static Random random = new Random();
        public static int LastDamage { get; private set; }
        public static void Example()
        { 

            var tyranid1Attack = new Tyranid1Attack("Tyranid Attack", 3, 2);
            int attacks = tyranid1Attack.Attacks;

            int total = 0;
            for (int i = 0; i < attacks; i++)
            {
                int diceRoll = random.Next(1, 7);
                total += diceRoll;
            }
            
            LastDamage = total * tyranid1Attack.Damage;
            Console.WriteLine($"Tyranid 1 delt {LastDamage} damage");
        }
    }
}
