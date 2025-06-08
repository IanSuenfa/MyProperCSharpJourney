using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class Class
    {
            class Dog {
                public int age;
                public string name;
                public string breed;

            }
        public static void Example()
        {
            Dog bog = new Dog();
            bog.age = 10;
            bog.name = "Bog";
            bog.breed = "Bulldog";
            Console.WriteLine(bog.age);
            Console.WriteLine(bog.name);
            Console.WriteLine(bog.breed);
        }
    }
}
