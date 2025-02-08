using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class TernaryOperator
    {
        public static void Example()
        {
            string input = Console.ReadLine();
            int score = Convert.ToInt32(input);
            string message = (score > 75) ? "Pass" : "Fail";
            Console.WriteLine(message); 
        }

    }   
}
