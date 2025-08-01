using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.WarHammers.Units;

namespace MyProperCSharpJourney.Exersise_work.WarHammers.Units
{
    public abstract class WHUnit
    {
        private bool _isAlive = true;
        public string Name { get; }
        public int Health { get; private set; }

        // FUTURE IAN ADD REGEN IF ATTACK AND TAKE DAMAGE IS FALSE!!!

        protected WHUnit(string name, int health)
        {
            Name = name;
            Health = health;
            _isAlive = health > 0;
        }

        public void Sleep(int hours)
        {
            if (!_isAlive)
            {
                Console.WriteLine($"{Name} is dead and cannot sleep to heal.");
                return;
            }
            else if (Health > 100)
            { Health = 100; }
            int healAmount = hours * 2;
            Health += healAmount;   
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            //Health -= Tyranid1Attacks.LastDamage;
            if (Health <= 0)
            {
                _isAlive = false;
                Health = 0;
            }
        }

        public bool IsAlive() => _isAlive;

        public void Status()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Name: {Name}");           
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Is Alive: {IsAlive()}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }
}
