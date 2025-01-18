using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.SoloLearn
{
    public static class ConcatentionAndInterpolation
    {
        public static void Example()
        {

            //Whats is a converting to null literal or possible null value to non-nullable type?
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine(); 

            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine(); 

            /*string sentence = "My name is " + name + " and I am " + age + " years old.";
            Console.WriteLine(sentence);*/
            string message = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(message);
        }
    }
}
