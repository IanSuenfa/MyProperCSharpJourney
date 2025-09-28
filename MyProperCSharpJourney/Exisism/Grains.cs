using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class Grains
    {
        public static void Example()

        {
            ulong totalGrains = (ulong)Math.Pow(2, 64) - 1;
            for (int n=1; n <= 64; n++)
            {
                ulong grains = (ulong)Math.Pow(2, n - 1);
                Console.WriteLine($"Square {n} has {grains} grains");
            }
            Console.WriteLine($"Total grains on a chessboard: 2^64 - 1 = {totalGrains}");
        }
    }
}
