using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class Arrays
    {
        public static void Example()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            double[] price = { 20000, 30000, 40000, 50000 };
            Console.WriteLine(cars[2] + " £" + price[2]);
        }
    }
}
