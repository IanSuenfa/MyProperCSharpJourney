using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class Raindrops
    {
        public static void Example()
        {
            Random random = new Random();
            int number = random.Next(1, 101);

            string result = "";
            if (number % 3 == 0)
            {
                result += "Pling";
            }
            if (number % 5 == 0)
            {
                result += "Plang";
            }
            if (number % 7 == 0)
            {
                result += "Plong";

            }
            else if (result == "")
            {
                result = number.ToString();
            }

            Console.WriteLine($"Generated number: {number}\nGenerated result: {result}");

            //Console.WriteLine($"Generated number: {number}");
            //if (number % 3 == 0 && number % 5 == 0 && number % 7 == 0)
            //{
            //    Console.WriteLine("PlingPlangPlong");
            //}
            //else if (number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine("PlingPlang");
            //}
            //else if (number % 3 == 0 && number % 7 == 0)
            //{
            //    Console.WriteLine("PlingPlong");
            //}
            //else if (number % 5 == 0 && number % 7 == 0)
            //{
            //    Console.WriteLine("PlangPlong");
            //}
            //else if (number % 3 == 0)
            //{
            //    Console.WriteLine("Pling");
            //}
            //else if (number % 5 == 0)
            //{
            //    Console.WriteLine("Plang");
            //}
            //else if (number % 7 == 0)
            //{
            //    Console.WriteLine("Plong");
            //}
            //else
            //{
            //    Console.WriteLine(number);
            //}


        }
    }
}
