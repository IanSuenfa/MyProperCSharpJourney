using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.Warhammer.Units;

namespace MyProperCSharpJourney.Exersise_work.Warhammer.Units.Tyranids
{
    public class Tyranid : Unit
    {
        public Tyranid(string name, int unitAmount, int saves, int toughness, int health, int regenHealth)
            : base(name, unitAmount, saves, toughness, health, regenHealth) { }

        internal object ShowWStats()
        {
            throw new NotImplementedException();
        }
    }

    public class TyranidAttack : Attack
    {
        public TyranidAttack(string name, int attacks, int weponStrength, int strength, int damage)
            : base(name, attacks, weponStrength, strength, damage) { }

    }

    //public static class T1
    //{
    //    public static void Example()
    //    {
    //        var Tyranid = new Tyranid("Tyranid", 5, 3, 4, 10);
    //        Tyranid.ShowStats();
    //    }
    //}
}
