using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class ArmstrongNumbers
    {
        public static void Example()
        {
            int number = 385;
            int originalNumber = number;
            int totalDigits = number.ToString().Length;
            int sum = 0;

            while (number > 0)
            {
                int digits = number % 10;
                sum += (int)Math.Pow(digits, totalDigits);
                number /= 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number");
            }

        }
    }
}
