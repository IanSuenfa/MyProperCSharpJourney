using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work
{
    public static class ATM
    {
        public static void Example()
        {
            Random random = new Random();
            int pin = random.Next(1000, 10000);
            int attempts = 3;
            
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Please enter your pin: (for testing "+ pin ,")");

            while(attempts > 0)
            {
                Console.Write("Enter your pin: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == pin)
                {
                    Console.WriteLine("Correct pin");
                    Console.WriteLine("You have access to your account");
                    Console.WriteLine("would you like to widraw or deposit money?");
                    Console.WriteLine("Please enter 'widraw' or 'deposit' for the selected action");
                    string action = Console.ReadLine();

                    if (action == "widraw")
                    {
                        Console.WriteLine("How much would you like to widraw?");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("you cannot widthdraw" + amount + " you have no money go get a job)");
                        break;
                    }
                    else if (action == "deposit")
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Thank you for your deposit");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid action");
                    }
                }
                else if (input != pin && (input < 1000 || input > 9999))
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("You have " + attempts + " attempts left (don't worry i didn't charge an attempt");
                    Console.WriteLine("Please enter a valid pin");
                }
                else
                {
                    Console.WriteLine("Incorrect pin");
                    attempts--;
                    Console.WriteLine("You have " + attempts + " attempts left");

                }


            }
            if (attempts == 0)
            {
                Console.WriteLine("You have used all your attempts");
                Console.WriteLine("Please contact your bank for assistance");
                Console.WriteLine("the card will now be swallowed by the machine");
            }
        }
    }
}
