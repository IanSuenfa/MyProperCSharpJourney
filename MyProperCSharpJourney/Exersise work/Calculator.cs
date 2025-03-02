using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work
{
    public static class Calculator
    {
        public static void Example()
        {
            Console.WriteLine("Welcome to Calculator");
            Console.WriteLine("Here is a list of opperators you can use");
            Console.WriteLine("Addition: +");
            Console.WriteLine("Subtraction: -");
            Console.WriteLine("Multiplication: *");
            Console.WriteLine("Division: /");
            Console.WriteLine("E.g: 5+5/7*8");
            Console.WriteLine("Type \"exit\" to Exit");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exit") 
                {
                    break;
                }

                try
                {
                    var result = new DataTable().Compute(input, null);
                    Console.WriteLine(input + " = " + result);
                }

                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
