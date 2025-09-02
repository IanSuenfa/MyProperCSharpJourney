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

            var tyranid1Attack = new TyranidAttack("Tyranid1 Attack", 3, 50);
            var tyranid2Attack = new TyranidAttack("Tyranid2 Attack", 3, 50);

            Random random = new Random();

            for (int round = 1; ; round++)
            {
                int hours = random.Next(1, 100);

                Console.WriteLine($"--- Round {round} ---");
                tyranid1.Status();
                tyranid2.Status();

                if (tyranid1.IsAlive())
                {

                }
                
                if (tyranid2.IsAlive())
                {

                }


                if (tyranid1.IsAlive() && tyranid2.IsAlive())
                {
                    int damageToTyranid2 = TyranidAttacks.Example(tyranid1Attack);
                    tyranid2.TakeDamage(damageToTyranid2);
                    Console.WriteLine($"Tyranid1 dealt {damageToTyranid2} damage to Tyranid2!");
                    tyranid2.Status();
                    int damageToTyranid1 = TyranidAttacks.Example(tyranid2Attack);
                    tyranid1.TakeDamage(damageToTyranid1);
                    Console.WriteLine($"Tyranid2 dealt {damageToTyranid1} damage to Tyranid1!");
                    tyranid1.Status();

                    tyranid1.Sleep(hours);
                    tyranid2.Sleep(hours);
                    
                }

                else if (!tyranid1.IsAlive() && !tyranid2.IsAlive())
                {
                    Console.WriteLine("Both Tyranids have been defeated! It's a draw!");
                }
                else if (!tyranid1.IsAlive())
                {
                    Console.WriteLine("Tyranid1 has been defeated! Tyranid2 wins!");
                }
                else if (!tyranid2.IsAlive())
                {
                    Console.WriteLine("Tyranid2 has been defeated! Tyranid1 wins!");
                }



                Console.WriteLine();
                Console.WriteLine("press 'ENTER' to continue the game");
                Console.WriteLine("Type 'end' to stop the game");

                string input = Console.ReadLine();
                
                if (input == "end")
                {
                    Console.WriteLine("Game ended by user.");
                    break;
                }
                else
                {
                    Console.WriteLine("continuing the game.");
                }

            }


        }
    }
}