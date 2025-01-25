using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work.Sypnapse
{
    public static class SypnapseEngine
    {
        public static void Example()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            while (true)
            {
                Console.WriteLine("Please enter your password");

                string password = Console.ReadLine();
                if (password == "3.14159265")
                {
                    Console.WriteLine("Password correct");
                    break;
                }
                else if (password == "HELP")
                {
                    Console.WriteLine("first 8 digits of a appley dessert");
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again");
                    Console.WriteLine("Press \"HELP\" for help");
                }
            }

            Console.WriteLine("Please press any button to continue");
            Console.ReadLine();
            
            Console.WriteLine("Welcome to the SypnapseEngine");

            Console.WriteLine("Enter [1] to play");
            Console.WriteLine("Enter [2] to see credits");
            Console.WriteLine("Enter [3] to exit");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Press [1] For: 289-B84");
                    Console.WriteLine("Press [2] For: ???");
                }
                else if (input == "2")
                {
                    Credits(name);
                }
                else if (input == "3")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

            private static void Credits(string name)
        {
            Console.WriteLine("Credits: ");
            Console.WriteLine("Created by: Ian");
            Console.WriteLine("Special thanks to: Ian");
            Console.WriteLine("Brought to you by: Sypnapse: Ian");
            Console.WriteLine("not brought to you by: M1l0");
            Console.WriteLine("im running out of ideas: Ian");
            Console.WriteLine("cool person: Ian and probably you " + name);
            Console.WriteLine("im really dragging this on: Ian");
            Console.WriteLine("ok im done: Ian");
            Console.WriteLine("not really: Ian");
            Console.WriteLine("ok now im done: Ian");
            Console.WriteLine("ok now im done like really done: Ian");
            Console.WriteLine("ok now im done like really done like really really done: Ian");
            Console.WriteLine("ok now im done like really done like really really done like really really done: Ian");
            Console.WriteLine("I mean it im done, I have lots planned for the future: Ian");
            Console.WriteLine("oh wait you can't leave");
            Console.WriteLine("Well before you go I'd like to give a special thanks to you for playing, is it playing? Idk if this is");
            Console.WriteLine("ok you can leave now");
            Console.WriteLine("ok bye");
            Console.WriteLine("ok bye for real");
            Console.WriteLine("ok bye for real for real");
            Console.WriteLine("ok bye for real for real for real");
            Console.WriteLine("ok bye for real for real for real for real");
            Console.WriteLine("oopsies forgot to write the command");
            Console.WriteLine("ok bye for real for real for real for real for real");
            Console.WriteLine("Press any button to exit");
            Console.ReadLine();
        }
    }
}
