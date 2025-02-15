using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class Parameters_ArgumentsExersise
    {
        public static void Example()
        {
            
            Console.WriteLine("Game list:");
            Console.WriteLine("1. Watching paint dry simulator");
            Console.WriteLine("2. Watching paint dry simulator 4 the sequel");
            Console.WriteLine("3. Watching paint dry simulator 4 the sequel deleuxe expantion pack");

            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            run(num);
            static void run(int num)
            {
                if (num == 1)
                {
                    Console.WriteLine("You have selected Watching paint dry simulator");
                }
                else if (num == 2)
                {
                    Console.WriteLine("You have selected Watching paint dry simulator 4 the sequel");
                }
                else if (num == 3)
                {
                    Console.WriteLine("You have selected Watching paint dry simulator 4 the sequel deleuxe expantion pack");
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
            }
        }
    }
}
