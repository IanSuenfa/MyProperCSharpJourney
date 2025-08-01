using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.WarHammers.Units;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public class tyranid1 : WHUnit
    {
        public tyranid1(string name, int health)
            : base(name, health) { }
    }

    public class Tyranid1Attack : WHAttack
    {
        public Tyranid1Attack(string name, int attacks, int damage)
            : base(name, attacks, damage) { }

    }
}
