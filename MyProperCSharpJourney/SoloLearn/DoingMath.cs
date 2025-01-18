using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.SoloLearn
{
    public static class DoingMath
    {
        public static void Example()
        {
            //A humming bird can flap it's wings 80 times a second
            //lets calcaulate how many times that happends in a minute
            Console.Write("A Hummingbird flaps it's wing 80 times a second");
            int FlapsPerSecond = 80;
            Console.WriteLine("This is how many times it flaps it's wing in a second");
            int FlapsPerMinute = FlapsPerSecond *60;
            
            Console.Write(FlapsPerMinute);

            Console.WriteLine();

            //you pay $54 for X amount of apples each apple costs $6 how many apples do you buy
            Console.WriteLine("you pay $54 for X amount of apples each apple costs $6 how many apples do you buy");
            int AppleTotalCost = 54;
            int PricePerApple = 6;
            int AmountOfApples = AppleTotalCost / PricePerApple;

            Console.WriteLine(AmountOfApples);       
        }
    }
}
