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
                var tyranid1 = new Tyranid("Tyranid1", 100);
                var tyranid2 = new Tyranid("Tyranid2", 100);

                var tyranid1Attack = new TyranidAttack("Tyranid1 Attack", 3, 2);
                var tyranid2Attack = new TyranidAttack("Tyranid2 Attack", 3, 2);

                int round = 1;
                Random random = new Random();

                while (tyranid1.IsAlive() && tyranid2.IsAlive())
                {
                    int hours = random.Next(1, 6);

                    Console.WriteLine($"--- Round {round} ---");
                    tyranid1.Status();
                    tyranid2.Status();

                    int damageToTyranid2 = TyranidAttacks.Example(tyranid1Attack);
                    tyranid2.TakeDamage(damageToTyranid2);
                    tyranid2.Status();
          
                    int damageToTyranid1 = TyranidAttacks.Example(tyranid2Attack);
                    tyranid1.TakeDamage(damageToTyranid1);
                    tyranid1.Status();

                    if (!tyranid1.IsAlive() && !tyranid2.IsAlive())
                    {
                        Console.WriteLine("Both Tyranids have been defeated! It's a draw!");
                        break;
                    }
                    else if (!tyranid1.IsAlive())
                    {
                        Console.WriteLine("Tyranid1 has been defeated! Tyranid2 wins!");
                        break;
                    }
                    else if (!tyranid2.IsAlive())
                    {
                        Console.WriteLine("Tyranid2 has been defeated! Tyranid1 wins!");
                        break;
                    }

                    tyranid1.Sleep(hours);
                    tyranid2.Sleep(hours);
                    Console.WriteLine($"Both Tyranids slept for {hours} hours.");
                    Console.WriteLine($"Tyranid1's health after sleep: {tyranid1.Health}");
                    Console.WriteLine($"Tyranid2's health after sleep: {tyranid2.Health}");
                    Console.WriteLine();

                    round++;
                    Console.WriteLine("Press Enter to continue to the next round...");
                    Console.ReadLine();
                }
            }
        }
    }