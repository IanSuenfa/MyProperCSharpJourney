using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class IfElse
{
    public static void Example()
    {
       
        string password = "password";
        

        while (true)
        {
            Console.WriteLine("Whats the password? " +
                "Type \"HELP\""+" for help");
            string PasswordInput = Console.ReadLine();


            if (password == PasswordInput)
            {
                Console.WriteLine("Correct password");
                break;
            }
            else if (PasswordInput == "HELP")
            {
                Console.WriteLine("it's password");
            }
            else
            {
                Console.WriteLine("Incorrect password, try again");
            }
        }
    }
}
