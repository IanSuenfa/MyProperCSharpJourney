using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class BeerSong
    {
        public static void Example()
        {
            for (int beers = 99; beers >= 1; beers--)
            {
                if (beers > 1)
                {
                    Console.WriteLine($"{beers} bottles of beer on the wall, {beers} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {beers - 1} of beer on the wall.\n");
                }
                else
                {
                    Console.WriteLine($"{beers} bottle of beer on the wall, {beers} bottle of beer.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.\n");
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                    Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
                }
            }

        }
    }
}
