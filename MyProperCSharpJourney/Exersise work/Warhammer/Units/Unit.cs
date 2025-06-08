using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperCSharpJourney.Exersise_work.Warhammer.Units;

namespace MyProperCSharpJourney.Exersise_work.Warhammer.Units
{
    
    
        public abstract class Unit
    {


            private bool _isAlive = true;
            
            private bool _isAttacking = true;
            public string Name { get; }
            public int UnitAmount { get; }
            public int Health { get; private set; }

            public int Toughness { get; private set; } 
            public int Saves { get; }

            public int RegenHealth { get; private set; }

            //FUTURE IAN ADD REGEN IF ATTACK AND TAKE DAMAGE IS FALSE!!!

        protected Unit(string name, int unitAmount, int saves, int toughness, int health, int regenHealth)
            {
                Name = name;
                UnitAmount = unitAmount;
                Saves = saves;
                Health = health;
                Toughness = toughness;
                _isAlive = health > 0;
                RegenHealth = regenHealth = 1;
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

            public void ShowStats()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Unit Amount: {UnitAmount}");
                Console.WriteLine($"Saves: {Saves}");
                Console.WriteLine($"Toughness: {Toughness}");
                Console.WriteLine($"Health: {Health}");
                Console.WriteLine($"Is Alive: {IsAlive()}");
            }

            public void Attack(Unit target)
            {
                Console.WriteLine($"{Name} attacks {target.Name}!");
                int damage = 1;
                target.TakeDamage(damage);
                Console.WriteLine($"{target.Name} takes {damage} damage!");
            }

        }
    
}
