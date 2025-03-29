using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class MultiDimesionArrays
    {
        public static void Example()
        {
            int[,] arr = new int[3, 2] { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            Console.WriteLine(arr[2, 1]);
        }
    }
}
