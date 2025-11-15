using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class Triangle
    {
        public static void Example()
        {
            Random random = new Random();
            int a = random.Next(1, 4);
            int b = random.Next(1, 4);
            int c = random.Next(1, 4);
            Console.WriteLine($"Triangle sides: a={a}, b={b}, c={c}");
            if (a == b && b == c)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (a == b || b == c  || c == a)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            
            else
            {
                Console.WriteLine("The triangle is scalene.");
            }
        }
    }
}
