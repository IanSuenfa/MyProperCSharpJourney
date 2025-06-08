using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.Warhammer.Units.Tyranids;
using MyProperCSharpJourney.Exersise_work.Warhammer.Units.SpaceMarines;
using MyProperCSharpJourney.Exersise_work.Warhammer.Units;


namespace MyProperCSharpJourney.Exersise_work
{

    public static class WhGame
    {
            public static void Example()
        {
            var tyranid = new Tyranid("Tyranid", 3, 3, 4, 3, 2);

            var spaceMarine = new SpaceMarine("Space Marine", 4, 5, 5, 3, 1);

            var PerailingLeap = new TyranidAttack("PerailingLeap", 3, 4, 5, 2);


            tyranid.ShowStats();
            spaceMarine.ShowStats();
            tyranid.ShowWStats();
            spaceMarine.ShowStats();


            

        }

        public static int RollDice()
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice roll: " + diceRoll);
            return diceRoll;
        }


        //Console.WriteLine("Test Tyranid attack first");
    }

}





