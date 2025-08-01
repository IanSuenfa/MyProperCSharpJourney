//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MyProperCSharpJourney.Exersise_work.WarHammers.Units;

//namespace MyProperCSharpJourney.Exersise_work.WarHammers
//{
//    public static class WHSim
//    {
//        private static Random random = new Random();

//        public static void Example()
//        {
//            var tyranid1Attack = new Tyranid1Attack("Tyranid Attack", 3, 2);
//            var tyranid2Attack = new Tyranid2Attack("Tyranid Attack", 3, 2);

//            int attacks1 = tyranid1Attack.Attacks;
//            int attacks2 = tyranid2Attack.Attacks;

//            int total = 0;
//            for (int i = 0; i < ; i++)
//            {
//                int diceRoll = random.Next(1, 7);
//                total += diceRoll;
//                Console.WriteLine($"Dice Roll {i + 1}: {diceRoll}");
//            }
            
//            int e = total * tyranid1Attack.Damage;
//            Console.WriteLine(e);
//        }
//    }
//}
