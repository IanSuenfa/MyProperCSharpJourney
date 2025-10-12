using MyProperCSharpJourney.SoloLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class PerfectNumbers
    {
        public static void Example()
        {
            int n = 6;
            int sum = 0;
            for (int i = 1; i < n; i++)   
            {
                if (n % i == 0)  
                {
                    sum += i;
                    Console.WriteLine(i); 
                }


            }
            if (sum == n)
            {
                Console.WriteLine($"{n} is Perfect");
            }
            else if (sum > n)
            {
                Console.WriteLine($"{n} is Abundant");
            }
            else if (sum < n)
            {
                Console.WriteLine($"{n} is Deficient");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

    }    
}
