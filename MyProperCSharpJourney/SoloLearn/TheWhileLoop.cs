using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class TheWhileLoop
    {
        public static void Example()
        {
            Console.WriteLine("While Loop Example");
            Console.WriteLine("YOU HAVE 5 LIVES");
            int i = 5;
            while (i >= 0)
            {
                Console.WriteLine($"You have {i} lives left");
                i--;
            }
        }
    }
}
