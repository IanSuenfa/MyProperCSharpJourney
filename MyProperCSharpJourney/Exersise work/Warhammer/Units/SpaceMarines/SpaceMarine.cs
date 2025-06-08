using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.Warhammer.Units;

namespace MyProperCSharpJourney.Exersise_work.Warhammer.Units.SpaceMarines
{
    public class SpaceMarine : Unit
    {
        public SpaceMarine(string name, int unitAmount, int saves, int toughness, int health, int regenHealth)
            : base(name, unitAmount, saves, toughness, health, regenHealth) { }
    }

    public class SpaceMarineAttack : Attack
    {
        public SpaceMarineAttack(string name, int attacks, int weponStrength, int strength, int damage)
            : base(name, attacks, weponStrength, strength, damage) { }
    }

    //public class SM1
    //{
    //    public static void Example()
    //    {
    //        var spaceMarine = new SpaceMarine("Space Marine", 5, 3, 4, 10);
    //        spaceMarine.ShowStats();
    //    }
    //}

}
