using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class SpaceAge{
        public static void Example()
        {
            Console.WriteLine("Enter Planet you are visiting:");
            Console.WriteLine("1. Mercury");
            Console.WriteLine("2. Venus");
            Console.WriteLine("3. Earth");
            Console.WriteLine("4. Mars");
            Console.WriteLine("5. Jupiter");
            Console.WriteLine("6. Saturn");
            Console.WriteLine("7. Uranus");
            Console.WriteLine("8. Neptune");
            int planet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your age in Earth years:");
            int age = Convert.ToInt32(Console.ReadLine());

            
            switch (planet)
            {
                case 1:
                    Console.WriteLine("Your age on Mercury is: " + age * 365 / 88);
                    break;
                case 2:
                    Console.WriteLine("Your age on Venus is: " + age * 365 / 225);
                    break;
                case 3:
                    Console.WriteLine("You don't need to know your age on earth you already are here");
                    break;
                case 4:
                    Console.WriteLine("Your age on Mars is: " + age * 365 / 687);
                    break;
                case 5:
                    Console.WriteLine("Your age on Jupiter is: " + age * 365 / 4333);
                    break;
                case 6:
                    Console.WriteLine("Your age on Saturn is: " + age * 365 / 10759);
                    break;
                case 7:
                    Console.WriteLine("Your age on Uranus is: " + age * 365 / 30687);
                    break;
                case 8:
                    Console.WriteLine("Your age on Neptune is: " + age * 365 / 60190);
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }    
    }
}
