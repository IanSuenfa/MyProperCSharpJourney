using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class TheForLoop
    {
        public static void Example()
        {

            Console.WriteLine("For Loop Example");
            Console.WriteLine("YOU HAVE 5 LIVES");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"You have {i} lives left");
            }
        }
    }
}
