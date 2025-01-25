using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTutorial.SoloLearn;

namespace MyProperCSharpJourney.Exersise_work.Sypnapse
{
    public static class SypnapseEngine
    {
        public static void Example()
        {
            Thread.Sleep(5000);
            Console.WriteLine("INITIALING...");
            Thread.Sleep(3000);
            Console.WriteLine("lOADING PACKAGES");
            Thread.Sleep(2000);
            Console.WriteLine("lOADING ASSETS");
            Thread.Sleep(2000);
            Console.WriteLine("lOADING SCRIPTS");
            Thread.Sleep(2000);
            Console.WriteLine("CURRENT SYSTEM MEMORY USAGE 500MB");
            Thread.Sleep(2000);
            Console.WriteLine("SYPNAPSE.EXE LOADED");
            Thread.Sleep(2000);
            Console.WriteLine("RUNNING SYPNAPSE ALPHA V1.3.5");
            Thread.Sleep(1000);
            Console.WriteLine("Sypnapse Incorporated:");
            Thread.Sleep(5000);
            Console.WriteLine("──────────────────────────────");
            Console.Write("───────────────▄▄───▐█\r\n");
            Console.Write("───▄▄▄───▄██▄──█▀───█─▄\r\n");
            Console.WriteLine("─▄██▀█▌─██▄▄──▐█▀▄─▐█▀");
            Console.Write("▐█▀▀▌───▄▀▌─▌─█─▌──▌─▌\r\n");
            Console.Write("▌▀▄─▐──▀▄─▐▄─▐▄▐▄─▐▄─▐▄\r\n");
            Console.Write("──────────────────────────────");
            Thread.Sleep(10000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("");
            Console.Write("░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗  ████████╗░█████╗░\r\n");
            Console.Write("░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝  ╚══██╔══╝██╔══██╗\r\n");
            Console.Write("░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░  ░░░██║░░░██║░░██║\r\n");
            Console.Write("░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░  ░░░██║░░░██║░░██║\r\n");
            Console.Write("░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗  ░░░██║░░░╚█████╔╝\r\n");
            Console.WriteLine("░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ░░░╚═╝░░░░╚════╝░\r\n");
            Console.Write("░██████╗██╗░░░██╗██████╗░███╗░░██╗░█████╗░██████╗░░██████╗███████╗  ███████╗███╗░░██╗░██████╗░██╗███╗░░██╗███████╗\r\n");
            Console.Write("██╔════╝╚██╗░██╔╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝██╔════╝  ██╔════╝████╗░██║██╔════╝░██║████╗░██║██╔════╝\r\n");
            Console.Write("╚█████╗░░╚████╔╝░██████╔╝██╔██╗██║███████║██████╔╝╚█████╗░█████╗░░  █████╗░░██╔██╗██║██║░░██╗░██║██╔██╗██║█████╗░░\r\n");
            Console.Write("░╚═══██╗░░╚██╔╝░░██╔═══╝░██║╚████║██╔══██║██╔═══╝░░╚═══██╗██╔══╝░░  ██╔══╝░░██║╚████║██║░░╚██╗██║██║╚████║██╔══╝░░\r\n");
            Console.Write("░╚═══██╗░░╚██╔╝░░██╔═══╝░██║╚████║██╔══██║██╔═══╝░░╚═══██╗██╔══╝░░  ██╔══╝░░██║╚████║██║░░╚██╗██║██║╚████║██╔══╝░░\r\n");
            Console.Write("██████╔╝░░░██║░░░██║░░░░░██║░╚███║██║░░██║██║░░░░░██████╔╝███████╗  ███████╗██║░╚███║╚██████╔╝██║██║░╚███║███████╗\r\n");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Thread.Sleep(5000);
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            while (true)
            {
                Console.WriteLine("Please enter your password");

                string password = Console.ReadLine();
                if (password == "314159265")
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

            Console.WriteLine("Please press ENTER to continue");
            Console.ReadKey();
            
            Console.WriteLine("Welcome to the SypnapseEngine Alpha 1.3.2");
            
            
            while (true)
            {
                Console.WriteLine("Enter [1] to play");
                Console.WriteLine("Enter [2] to see credits");
                Console.WriteLine("Enter [3] to exit");


               
                Console.WriteLine("");
                string MenuInput = Console.ReadLine();
                if (MenuInput == "1")
                    {
                    Console.WriteLine("Press [1]");
                    Console.WriteLine("Press [2]");
                    string GameInput = Console.ReadLine();
                    if (GameInput == "1")
                        {
                            Game1();
                        }
                        else if (GameInput == "2")
                        {
                        Game2();
                        }
                        else if (GameInput == "3")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }

                    }
                    else if (MenuInput == "2")
                    {
                        Credits(name);
                    }


                else if (MenuInput == "3")
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, Rolling back to last command...");
                    }


            }
        }

            private static void Game1()
        {
            Console.WriteLine("You have selected 289-B84");
            Console.WriteLine("Error code: 9694 failed to load assets(aka the developer wasnt bothered to add any games yet becuase he is an F- ranked coder)");
            Console.WriteLine("Press any button to exit");
            Console.ReadLine();
        }


        private static void Game2()
        {
            Console.WriteLine("You have selected ???");
            Console.WriteLine("Game packages unloading");
            Console.WriteLine("Initalising Snapshot Beta 1.1.1");
            Console.WriteLine("An error ocurred whilst loading [SNAPSHOT BETA 1.1.1] to maintain Alpha's PackageIntegrety_Program_(???) has been terminated");
            Console.WriteLine("Attempting to restart Sypnapse");
            Console.WriteLine("An error has been found");
            Console.WriteLine("Error code: 0647");
            Console.WriteLine("Error: Failed to load assets");
            Console.WriteLine("Warning packages are C0rRuPT1Ng");
            Console.WriteLine("AUt0m3T1c FA1L sAf3 1NITIaT1nG");
            Console.WriteLine("Program Succesfully rolled back to Alpha 1.1.34");
            Console.WriteLine("Version may be unstable due to the older impending application");
            Console.WriteLine("Press any button to initiate rollback restart");
            Console.ReadLine();
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
            Console.WriteLine("Initalising...");
            Console.WriteLine("Press any button to exit");
            Console.ReadKey();
        }
    }
}
