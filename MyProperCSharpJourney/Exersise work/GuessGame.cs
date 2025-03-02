using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTutorial.SoloLearn;

namespace MyProperCSharpJourney.Exersise_work
{   
    public static class GuessGame
    {
        public static void Example()
        {
            //not finished ignore this  
            //Console.WriteLine("Welcome to the Guessing Game!");
            //Thread.Sleep(3000);
            //Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it!");
            //Thread.Sleep(4000);
            //Console.WriteLine("Don't worry user, if you think about it on your first go thats a 1% chance, very small but after that,");
            //Thread.Sleep(2000);
            //Console.WriteLine("2nd guess: 1 out of 99 (1.01%)\r\n3rd guess: 1 out of 98 (1.02%)\r\n4th guess: 1 out of 97 (1.03%)\r\n5th guess: 1 out of 96 (1.04%)\r\n6th guess: 1 out of 95 (1.05%)\r\n7th guess: 1 out of 94 (1.06%)\r\n8th guess: 1 out of 93 (1.08%)\r\n9th guess: 1 out of 92 (1.09%)\r\n10th guess: 1 out of 91 (1.1%)\r\n11th guess: 1 out of 90 (1.11%)\r\n12th guess: 1 out of 89 (1.12%)\r\n13th guess: 1 out of 88 (1.14%)\r\n14th guess: 1 out of 87 (1.15%)\r\n15th guess: 1 out of 86 (1.16%)\r\n16th guess: 1 out of 85 (1.18%)\r\n17th guess: 1 out of 84 (1.19%)\r\n18th guess: 1 out of 83 (1.2%)\r\n19th guess: 1 out of 82 (1.22%)\r\n20th guess: 1 out of 81 (1.23%)\r\n21st guess: 1 out of 80 (1.25%)\r\n22nd guess: 1 out of 79 (1.27%)\r\n23rd guess: 1 out of 78 (1.28%)\r\n24th guess: 1 out of 77 (1.3%)\r\n25th guess: 1 out of 76 (1.32%)\r\n26th guess: 1 out of 75 (1.33%)\r\n27th guess: 1 out of 74 (1.35%)\r\n28th guess: 1 out of 73 (1.37%)\r\n29th guess: 1 out of 72 (1.39%)\r\n30th guess: 1 out of 71 (1.41%)\r\n31st guess: 1 out of 70 (1.43%)\r\n32nd guess: 1 out of 69 (1.45%)\r\n33rd guess: 1 out of 68 (1.47%)\r\n34th guess: 1 out of 67 (1.49%)\r\n35th guess: 1 out of 66 (1.52%)\r\n36th guess: 1 out of 65 (1.54%)\r\n37th guess: 1 out of 64 (1.56%)\r\n38th guess: 1 out of 63 (1.59%)\r\n39th guess: 1 out of 62 (1.61%)\r\n40th guess: 1 out of 61 (1.64%)\r\n41st guess: 1 out of 60 (1.67%)\r\n42nd guess: 1 out of 59 (1.69%)\r\n43rd guess: 1 out of 58 (1.72%)\r\n44th guess: 1 out of 57 (1.75%)\r\n45th guess: 1 out of 56 (1.79%)\r\n46th guess: 1 out of 55 (1.82%)\r\n47th guess: 1 out of 54 (1.85%)\r\n48th guess: 1 out of 53 (1.89%)\r\n49th guess: 1 out of 52 (1.92%)\r\n50th guess: 1 out of 51 (1.96%)\r\n51st guess: 1 out of 50 (2%)\r\n52nd guess: 1 out of 49 (2.04%)\r\n53rd guess: 1 out of 48 (2.08%)\r\n54th guess: 1 out of 47 (2.13%)\r\n55th guess: 1 out of 46 (2.17%)\r\n56th guess: 1 out of 45 (2.22%)\r\n57th guess: 1 out of 44 (2.27%)\r\n58th guess: 1 out of 43 (2.33%)\r\n59th guess: 1 out of 42 (2.38%)\r\n60th guess: 1 out of 41 (2.44%)\r\n61st guess: 1 out of 40 (2.5%)\r\n62nd guess: 1 out of 39 (2.56%)\r\n63rd guess: 1 out of 38 (2.63%)\r\n64th guess: 1 out of 37 (2.7%)\r\n65th guess: 1 out of 36 (2.78%)\r\n66th guess: 1 out of 35 (2.86%)\r\n67th guess: 1 out of 34 (2.94%)\r\n68th guess: 1 out of 33 (3.03%)\r\n69th guess: 1 out of 32 (3.13%)\r\n70th guess: 1 out of 31 (3.23%)\r\n71st guess: 1 out of 30 (3.33%)\r\n72nd guess: 1 out of 29 (3.45%)\r\n73rd guess: 1 out of 28 (3.57%)\r\n74th guess: 1 out of 27 (3.7%)\r\n75th guess: 1 out of 26 (3.85%)\r\n76th guess: 1 out of 25 (4%)\r\n77th guess: 1 out of 24 (4.17%)\r\n78th guess: 1 out of 23 (4.35%)\r\n79th guess: 1 out of 22 (4.55%)\r\n80th guess: 1 out of 21 (4.76%)\r\n81st guess: 1 out of 20 (5%)\r\n82nd guess: 1 out of 19 (5.26%)\r\n83rd guess: 1 out of 18 (5.56%)\r\n84th guess: 1 out of 17 (5.88%)\r\n85th guess: 1 out of 16 (6.25%)\r\n86th guess: 1 out of 15 (6.67%)\r\n87th guess: 1 out of 14 (7.14%)\r\n88th guess: 1 out of 13 (7.69%)\r\n89th guess: 1 out of 12 (8.33%)\r\n90th guess: 1 out of 11 (9.09%)\r\n91st guess: 1 out of 10 (10%)\r\n92nd guess: 1 out of 9 (11.11%)\r\n93rd guess: 1 out of 8 (12.5%)\r\n94th guess: 1 out of 7 (14.29%)\r\n95th guess: 1 out of 6 (16.67%)\r\n96th guess: 1 out of 5 (20%)\r\n97th guess: 1 out of 4 (25%)\r\n98th guess: 1 out of 3 (33.33%)\r\n99th guess: 1 out of 2 (50%)\r\n100th guess: 1 out of 1 (100%)\r\nWith every wrong guess, the number of possibilities gets smaller, and your chance of getting the correct answer improves. By the time you reach the 100th guess, you're guaranteed to guess the right number!\r\n\r\nKeep going! You'll get closer with every guess.\"\r\n\r\n 😊");
            //Thread.Sleep(2000);
            //Console.WriteLine("not that much anyway");
            //Thread.Sleep(2000);
            //Console.WriteLine("what too much?");
            //Thread.Sleep(2000);
            //Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it!");
            //Thread.Sleep(4000);
            //Console.WriteLine("oh, so your got gonna comply? Fine");
            //Thread.Sleep(3000);
            //Console.WriteLine("I'm thinking of a number between 1 and 20. Try to guess it!");
            //Thread.Sleep(4000);
            //Console.WriteLine("STILL TO MUCH");
            //Thread.Sleep(3000);
            //Console.WriteLine("I'm thinking of a number between 1 and 10. Try to guess it!");
            //Thread.Sleep(4000);
            //Console.WriteLine("I'LL THINK OF A NUMBER BETWEEN 1 AND 10 TAKE OR LEAVE");
            //Thread.Sleep(3000);
            //Console.WriteLine("Ok lets start, (PS: since you didnt want to do my original plan i have a solution");
            //Thread.Sleep(3000);
            Random random = new Random();
            int number = random.Next(1, 11);
            int guess = 0;
            int attempts = 0;
            Console.WriteLine("I'm thinking of a number between 1 and 10. Try to guess it! You have 5 attempts.");
            Thread.Sleep(1000);
            while (guess != number && attempts < 5)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                guess = Convert.ToInt32(input);
                attempts++;
                if (guess == number)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("YOU WIN YIPEEE");
                }
                else if (guess != number)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("WRONG GUESS");
                    Console.WriteLine("You have: " + (5 - attempts) + "attempts left");
                }
                //else
                //{
                //    Thread.Sleep(10000);
                //    Console.WriteLine("ENTER A VALID NUMBER AND SINCE YOU WASTED MY TIME THATS MINUS 1 GUESS");
                //    Console.WriteLine("You have:", attempts, "left");
                //}

                if (attempts == 5)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("You have used all your guesses");
                    Console.WriteLine("The number was: " + number);

                    Console.ReadKey();
                }
            }
        }

    }
}
