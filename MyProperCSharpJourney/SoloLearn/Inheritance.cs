using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class Inheritance
    {
        
        private class Animal
        {
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }
        }
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} is barking.");
            }
        }

        public static void Example()
        {
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            myDog.Eat(); // Inherited method
            myDog.Bark(); // Dog's own method
        }
    }
}