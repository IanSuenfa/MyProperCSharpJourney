using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work.Warhammer
{
    public class Tyranid : Unit
    {
        public Tyranid(string name, int unitAmount, int saves, int toughness, int health)
            : base(name, unitAmount, saves, toughness, health) { }

        

    }

    public static class T1
    {
        public static void Example()
        {
            var Tyranid = new Tyranid("Tyranid", 5, 3, 4, 10);
            Tyranid.ShowStats();
        }
    }
}
