using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work.Warhammer.Units
{
    public abstract class Attack
    {
        public string Name { get; }
        public int Attacks { get; }
        public int WeponStrength { get; }
        public int Strength { get; }
        public int Damage { get; }

        protected Attack(string name, int attacks, int weponStrength, int strength, int damage)
        {
            Name = name;
            Attacks = attacks;
            WeponStrength = weponStrength;
            Strength = strength;
            Damage = damage;
        }

        public void ShowWStats()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Number of Attacks: {Attacks}");
            Console.WriteLine($"Wepon's Strength: {WeponStrength}");
            Console.WriteLine($"Strenght: {Strength}");
            Console.WriteLine($"Damage: {Damage}");
        }


    }
}
