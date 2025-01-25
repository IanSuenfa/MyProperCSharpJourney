using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ComparisonOperators
{
    public static void Example()
    {
        int a = 5;
        int b = 3;
        Console.WriteLine(a > b); // True
        Console.WriteLine(a < b); // False
        Console.WriteLine(a >= b); // True
        Console.WriteLine(a <= b); // False
        Console.WriteLine(a == b); // False
        Console.WriteLine(a != b); // True

        string password = "password";
        Console.WriteLine("Whats the password?");
        string passwordInput = Console.ReadLine();
        Console.WriteLine(password == passwordInput);
    }
}