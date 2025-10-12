using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class DifferenceOfSquare
    {
        public static void Example()
        {
            int n = 10;
            int squareOfSum = (int)Math.Pow(n * (n + 1) /2, 2);
            int sumOfSquares = n * (n + 1) * (2 * n + 1) / 6;
            int difference = squareOfSum - sumOfSquares;
            Console.WriteLine($"The difference between the square of the sum and the sum of the squares for the first {n} natural numbers is: {difference}");

        }
    }

}
