using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public abstract class WHAttack
    {
        public string Name { get; }
        public int Attacks { get; }
        public int Damage { get; }

        protected WHAttack(string name, int attacks, int damage)
        {
            Name = name;
            Attacks = attacks;
            Damage = damage;
        }

        public void Status2()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Number of Attacks: {Attacks}");
            Console.WriteLine($"Damage: {Damage}");
        }
    }
}
