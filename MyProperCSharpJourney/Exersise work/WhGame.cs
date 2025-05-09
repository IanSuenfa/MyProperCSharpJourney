using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MyProperCSharpJourney.Exisism;

//namespace MyProperCSharpJourney.Exersise_work
//{
//    public abstract class Unit
//    {
//        private bool _isAlive = true;
//        public string Name { get; }
//        public int UnitAmount { get; }
//        public int Health { get; private set; }

//        public int Toughness { get; private set; }
//        public int Saves { get; }

//        protected Unit(string name, int unitAmount, int saves, int toughness, int health)
//        {
//            Name = name;
//            UnitAmount = unitAmount;
//            Saves = saves;
//            Health = health;
//            Toughness = toughness; 
//            _isAlive = health > 0;
//        }

//        public void TakeDamage(int damage)
//        {
//            Health -= damage;
//            if (Health <= 0)
//            {
//                _isAlive = false;
//            }
//        }

//        public bool IsAlive() => _isAlive;
//    }

//    public class Tyranid : Unit
//    {
//        public Tyranid(string name, int unitAmount, int saves, int toughness, int health)
//            : base(name, unitAmount, saves, toughness, health) { }

//        public static void Example()
//        {
//            Tyranid leaper = new Tyranid("Leaper", 3, 3, 5, 3);
//            Console.WriteLine(leaper.Name);
//            Console.WriteLine(leaper.UnitAmount);
//            Console.WriteLine(leaper.Saves);
//            Console.WriteLine(leaper.Toughness);
//            Console.WriteLine(leaper.Health);
//            Console.WriteLine(leaper.IsAlive());

//            Console.WriteLine("Choose your wepon");
//            Console.WriteLine("1. Leapers perail");
//            Console.WriteLine("Attacks: 6 ");
//            Console.WriteLine("Wounds: 4+");
//            Console.WriteLine("Strength: 5");
//            Console.WriteLine("Damage: 3");
//            Console.WriteLine("");
//            Console.WriteLine("2. Venemorph Scythes:");
//            Console.WriteLine("Attacks: 2 ");
//            Console.WriteLine("Wounds: 3+");
//            Console.WriteLine("Strength: 6");
//            Console.WriteLine("Damage: 4");
 
//            int TWepon = Convert.ToInt16(Console.ReadLine());
//            if (TWepon == 1)
//            {
//                Console.WriteLine("Leapers perail");
//                LeapersPerail.Example();

//            }
//            else if (TWepon == 2)
//            {
//                Console.WriteLine("Venemorph Scythes");
//            }
            
//            else
//            {
//                Console.WriteLine("Invalid selection");
//            }

//        }

//        public class LeapersPerail
//        {
//            public static void Example()
//            {
//                Tyranid leapers = new Tyranid("Leapers perail", 3, 3, 5, 3);
//                int TLPAttacks = 6 * leapers.UnitAmount;
//                int hitCounter = 0;
//                for (int i = 0; i < TLPAttacks; i++)
//                {
//                    int diceRoll = WhGame.RollDice();
//                    if (diceRoll >= 4)
//                    {
//                        hitCounter++;
//                    }
//                }
//                Console.WriteLine("Total hits:" + hitCounter);
//                Console.WriteLine(leapers.Saves);
//                Console.WriteLine(leapers.Toughness);
//                Console.WriteLine(leapers.Health);
//                Console.WriteLine(leapers.IsAlive());
//            }
            
//        }

//    }

//    public class SpaceMarine : Unit
//    {
//        public SpaceMarine(string name, int unitAmount, int saves, int toughness, int health)
//            : base(name, unitAmount, saves, toughness, health) { }

//        public static void Example()
//        {
//            SpaceMarine marine = new SpaceMarine("Marine", 4, 5, 4, 3);
//            Console.WriteLine(marine.Name);
//            Console.WriteLine(marine.UnitAmount);
//            Console.WriteLine(marine.Saves);
//            Console.WriteLine(marine.Toughness);
//            Console.WriteLine(marine.Health);
//            Console.WriteLine(marine.IsAlive());
//        }
//    }

//    public static class WhGame
//    {
//        public static void Example()
//        {
//            //Console.WriteLine("Welcome to the Warhammer 40k game!");
//            //Console.WriteLine("Choose your faction:");
//            //Console.WriteLine("1. Tyranids");
//            //Console.WriteLine("2. Space Marines");
//            //int Faction = Convert.ToInt16(Console.ReadLine());
//            //if (Faction == 1)
//            //{
//            //    Tyranid.Example();
//            //}
//            //else if (Faction == 2)
//            //{
//            //    SpaceMarine.Example();
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Invalid selection");
//            //}
//        }

//        public static int RollDice()
//        {
//            Random random = new Random();
//            int diceRoll = random.Next(1, 7);
//            Console.WriteLine("Dice roll: " + diceRoll);
//            return diceRoll;
//        }
//    }

//}

    


