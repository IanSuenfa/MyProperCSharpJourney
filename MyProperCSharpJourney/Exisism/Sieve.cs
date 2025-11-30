using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class Sieve
    {
        public static void Example()
        {
            int n = 100;
            bool [] isPrime = new bool[n + 1];
            for(int i = 2; i <= n; i++)
            {
                 isPrime[i] = true;
            }

            for(int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for(int multiple = p * p; multiple <= n; multiple += p)
                    {
                        isPrime[multiple] = false;
                    }
                }
            }
            Console.WriteLine("Prime numbers:");
            for (int i = 2; i <= n; i++)
                if (isPrime[i])
                    Console.Write(i + " ");

        }
    }
}

