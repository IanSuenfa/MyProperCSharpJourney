using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class Darts
    {
        public static void Example()
        {
            Random random = new Random();
            int x = random.Next(-10, 11);
            int y = random.Next(-10, 11);
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine($"Dart landed at ({x}, {y})");
            Console.WriteLine($"Distance from center: {distance}");
            if (distance <= 1)
            {
                Console.WriteLine("Score: 10 points");
            }
            else if (distance <= 5)
            {
                Console.WriteLine("Score: 5 points");
            }
            else if (distance <= 10)
            {
                Console.WriteLine("Score: 1 point");
            }
            else
            {
                Console.WriteLine("Score: 0 points");
            }

        }
    }
}
