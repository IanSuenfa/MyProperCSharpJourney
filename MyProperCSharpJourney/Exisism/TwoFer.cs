using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class TwoFer
    {
        public static void Example(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
               Console.WriteLine("One for you, one for me.");
            }
            else
            {
                Console.WriteLine($"One for {name}, one for me.");
            }
        }
    }
}
