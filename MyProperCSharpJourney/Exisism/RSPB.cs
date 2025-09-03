using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exisism
{
    public static class RSPB
    {
        public static void Example()
        {
            Random rand = new Random();

            string[] birdTypes = { "robin", "starling", "blackbird", "sparrow" };
            List<string> birdsSeen = new List<string>();

            Dictionary<string, int> birdCount = new Dictionary<string, int>();
            foreach (var capitalise in birdTypes)
            {
                birdCount[char.ToUpper(capitalise[0]) + capitalise.Substring(1)] = 0;
            }

            int birdAmount = 20;
            for (int i = 0; i < birdAmount; i++)
            {
                int randomBird = rand.Next(0, birdTypes.Length);
                birdsSeen.Add(birdTypes[randomBird]);
            }
            birdsSeen = birdsSeen.Select(capitalise => char.ToUpper(capitalise[0]) + capitalise.Substring(1)).ToList();


            foreach (var currentBird in birdsSeen)
            {
                birdCount[currentBird]++;
            }

            foreach (var birdCountBefore in birdCount) 
            {
                Console.WriteLine($"{birdCountBefore.Key}: {birdCountBefore.Value}");
            }

            Console.WriteLine("");
            Console.WriteLine("4 more blackbirds spotted");

            birdCount["Blackbird"] += 4;

            Console.WriteLine("");
            Console.WriteLine("Final Report:");
            Console.WriteLine("");

            foreach (var updatedBirdCount in birdCount)
            {
                Console.WriteLine($"{updatedBirdCount.Key}: {updatedBirdCount.Value}");
            }
        }
    }
}
