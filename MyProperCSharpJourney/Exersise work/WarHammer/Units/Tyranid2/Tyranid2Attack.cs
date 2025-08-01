using MyProperCSharpJourney.Exersise_work.WarHammers.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public static class Tyranid2Attacks
    {
        private static Random random = new Random();

        public static int LastDamage { get; private set; }
        public static void Example()
        {
            var tyranid2Attack = new Tyranid2Attack("Tyranid Attack", 3, 2);

            int attacks = tyranid2Attack.Attacks;

            int total = 0;
            for (int i = 0; i < attacks; i++)
            {
                int diceRoll = random.Next(1, 7);
                total += diceRoll;
            }
            LastDamage = total * tyranid2Attack.Damage;
            Console.WriteLine($"Tyranid 2 delt {LastDamage} damage");
        }
    }
}
