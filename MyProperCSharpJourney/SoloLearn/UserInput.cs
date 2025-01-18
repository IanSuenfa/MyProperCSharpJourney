using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.SoloLearn
{
    public static class UserInput
    {
        public static void Example()
        {
            Console.WriteLine("Welcome to the super simple summing calculator! Just enter 2 numbers!");

            //taking the inputs and converting them to int
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Calculating the sum of the two numbers
            int sum = num1 + num2;
            
            Console.WriteLine("The sum of the two numbers are:\t" + sum);
            //Console.Write(sum);
        }
    }
}
