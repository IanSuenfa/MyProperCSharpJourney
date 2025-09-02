using MyProperCSharpJourney.Exersise_work.WarHammers.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.WarHammers;
using MyProperCSharpJourney.Exersise_work.WarHammers.Units;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public static class TyranidAttacks
    {
        private static Random random = new Random();
        public static int damageDealt { get; private set; }
        public static int Example(WHAttack attack)
        {
            int total = 0;
            for (int i = 0; i < attack.Attacks; i++)
            {
                int diceRoll = random.Next(1, 7);
                total += diceRoll;
            }

            damageDealt = total * attack.Damage;
            return damageDealt;
        }

    }
}
