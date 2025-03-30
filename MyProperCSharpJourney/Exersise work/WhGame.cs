using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyProperCSharpJourney.Exersise_work
{
    public abstract class Unit
    {
        private bool _isAlive = true;
        public string Name { get; }
        public int UnitAmount { get; }
        public int Health { get; private set; }
        public int Strength { get; }

        protected Unit(string name, int unitAmount, int strength, int health)
        {
            Name = name;
            UnitAmount = unitAmount;
            Strength = strength;
            Health = health;
            _isAlive = health > 0;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                _isAlive = false;
            }
        }

        public bool IsAlive() => _isAlive;
    }

    public class Tyranid : Unit
    {
        public Tyranid(string name, int unitAmount, int strength, int health)
            : base(name, unitAmount, strength, health) { }

        public static void Example()
        {
            Tyranid leaper = new Tyranid("Leaper", 3, 5, 3);
            Console.WriteLine(leaper.Name);
            Console.WriteLine(leaper.UnitAmount);
            Console.WriteLine(leaper.Strength);
            Console.WriteLine(leaper.Health);
            Console.WriteLine(leaper.IsAlive());
        }
    }

    public class SpaceMarine : Unit
    {
        public SpaceMarine(string name, int unitAmount, int strength, int health)
            : base(name, unitAmount, strength, health) { }

        public static void Example()
        {
            SpaceMarine marine = new SpaceMarine("Marine", 4, 2, 4);
            Console.WriteLine(marine.Name);
            Console.WriteLine(marine.UnitAmount);
            Console.WriteLine(marine.Strength);
            Console.WriteLine(marine.Health);
            Console.WriteLine(marine.IsAlive());
        }
    }

    public static class WhGame
    {
        public static void Example()
        {
            //Console.WriteLine("Welcome to the Warhammer 40k game!");
            //Console.WriteLine("Choose your faction:");
            //Console.WriteLine("1. Tyranids");
            //Console.WriteLine("2. Space Marines");
            //int Faction = Convert.ToInt16(Console.ReadLine());
            //if (Faction == 1)
            //{
            //    Tyranid.Example();
            //}
            //else if (Faction == 2)
            //{
            //    SpaceMarine.Example();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid selection");
            //}
        }
        
    }
}

