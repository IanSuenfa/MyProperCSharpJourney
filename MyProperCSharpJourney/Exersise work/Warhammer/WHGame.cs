using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.WarHammers.Units;
using MyProperCSharpJourney.Exersise_work.WarHammers;

namespace MyProperCSharpJourney.Exersise_work.WarHammers
{
    public static class WHGame
    {
        public static void Example()

        {
            var tyranid1 = new tyranid1("Tyranid1", 100);
            var tyranid2 = new Tyranid2("Tyranid2", 100);
            int round = 1;

            while (tyranid1.IsAlive() && tyranid2.IsAlive())
            {
                Random random = new Random();
                int hours = random.Next(1, 6);
                Console.WriteLine("Both Tyranids are alive and ready to fight!");
                Console.WriteLine($"Round {round}:");
                tyranid1.Status();
                tyranid2.Status();

                Tyranid1Attacks.Example();
                Tyranid2Attacks.Example();

                tyranid2.TakeDamage(Tyranid1Attacks.LastDamage);                
                tyranid2.Status();

                tyranid1.TakeDamage(Tyranid2Attacks.LastDamage);
                tyranid1.Status();

                Console.WriteLine($"round {round} completed");
                Console.WriteLine("");

                if (!tyranid1.IsAlive())
                {
                    Console.WriteLine("Tyranid1 has been defeated!");
                    Console.WriteLine("Tyranid2 is the winner!");
                    break;
                }
                else if (!tyranid2.IsAlive())
                {
                    Console.WriteLine("Tyranid2 has been defeated!");
                    Console.WriteLine("Tyranid1 is the winner!");
                    break;
                }

                else if (!tyranid1.IsAlive() && !tyranid2.IsAlive())
                {
                    Console.WriteLine("Both Tyranids have been defeated!");
                    Console.WriteLine("It's a draw!");
                    break;
                }

                tyranid1.Sleep(hours);
                tyranid2.Sleep(hours);

                Console.WriteLine($"Both Tyranids slept for {hours} hours");
                Console.WriteLine("");
                Console.WriteLine($"Tyranid1's health after sleep: {tyranid1.Health}");
                Console.WriteLine($"Tyranid2's health after sleep: {tyranid2.Health}");
                Console.WriteLine("");

                Console.WriteLine("Press Enter to continue to the next round...");
                string nextRound = Console.ReadLine();

                round++;
            }
        }
    }
}

 