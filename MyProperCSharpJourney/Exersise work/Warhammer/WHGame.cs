using MyProperCSharpJourney.Exersise_work.Warhammer;

namespace MyProperCSharpJourney.Exersise_work
{
    public abstract class Unit
    {
        private bool _isAlive = true;
        public string Name { get; }
        public int UnitAmount { get; }
        public int Health { get; private set; }

        public int Toughness { get; private set; }
        public int Saves { get; }

        protected Unit(string name, int unitAmount, int saves, int toughness, int health)
        {
            Name = name;
            UnitAmount = unitAmount;
            Saves = saves;
            Health = health;
            Toughness = toughness;
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
            int damage = -1;
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} takes {damage} damage!");
        }

    }





    public static class WhGame
    {
        public static void Example()
        {
            
        }

        public static int RollDice()
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice roll: " + diceRoll);
            return diceRoll;
        }
    }

}





