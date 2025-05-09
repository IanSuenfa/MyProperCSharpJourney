using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work.Warhammer
{
    public class SpaceMarine : Unit
    {
        public SpaceMarine(string name, int unitAmount, int saves, int toughness, int health)
            : base(name, unitAmount, saves, toughness, health) { }



    }

    public class SM1
    {
        public static void Example()
        {
            var spaceMarine = new SpaceMarine("Space Marine", 5, 3, 4, 10);
            spaceMarine.ShowStats();
        }
    }

}
