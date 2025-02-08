using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class LogicalOperators
    {
        public static void Example()
        {
            int a = 5;
            int b = 3;
            int c = 7;
            Console.WriteLine(a > b && a < c); 
            Console.WriteLine(a > b && a > c); 
            Console.WriteLine(a > b || a > c); 
            Console.WriteLine(!(a > b)); 
            Console.WriteLine(!(a < b)); 
            Console.WriteLine(!(a < c));
            Console.WriteLine(!(a > b));
            Console.WriteLine(!(a < c));
            Console.WriteLine(!(a < b));
            Console.WriteLine(!(a > c));
        }
    }
}
