using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    public static class Enums
    {
        public static void Example()
        {
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine(today);            
            Console.WriteLine((int)today);       
        }
    }

}