using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class Leap
    {
        public static bool Example(int year)
        {
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            Console.WriteLine(isLeapYear ? $"{year} is a leap year." : $"{year} is not a leap year.");

            return isLeapYear;
        }
    }
}

