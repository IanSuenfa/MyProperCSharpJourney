using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.WarHammers.Units;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public class Tyranid : WHUnit
    {
        public Tyranid(string name, int health)
            : base(name, health) { }
    }

    public class TyranidAttack : WHAttack
    {
        public TyranidAttack(string name, int attacks, int damage)
            : base(name, attacks, damage) { }

    }
}
