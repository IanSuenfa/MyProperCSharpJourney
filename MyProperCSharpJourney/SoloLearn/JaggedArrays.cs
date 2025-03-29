using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class JaggedArrays
    {
        public static void Example()
        {

            int[][] jaggedArr = new int[3][];
            

            jaggedArr[0] = new int[] { 1, 8, 2, 7, 9 };
            jaggedArr[1] = new int[] { 2, 4, 6 };
            jaggedArr[2] = new int[] { 33, 42 };


            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Element({0}): ", i);
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write("{0} ", jaggedArr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
