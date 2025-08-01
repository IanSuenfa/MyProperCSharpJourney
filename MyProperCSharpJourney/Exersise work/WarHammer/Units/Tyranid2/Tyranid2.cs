using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.WarHammers.Units;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public class Tyranid2 : WHUnit
    {
        public Tyranid2(string name, int health)
            : base(name, health) { }
    }

    public class Tyranid2Attack : WHAttack
    {
        public Tyranid2Attack(string name, int attacks, int damage)
            : base(name, attacks, damage) { }
    }
}
