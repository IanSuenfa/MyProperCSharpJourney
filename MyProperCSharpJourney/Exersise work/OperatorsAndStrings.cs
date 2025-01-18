using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work
{
    public class OperatorsAndStrings
    {
        public static void Example()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Conection initiated");
            Thread.Sleep(3000);
            Console.WriteLine("Hello there! My name is Milo.");
            Thread.Sleep(2000);
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); 
            Thread.Sleep(1000);
            Console.WriteLine("Hello " + name + "!");
            Thread.Sleep(1000);
            Console.WriteLine("how old are you " + name + "?");
            int age = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(2000);
            Console.WriteLine("Where do you live " + name + "?");
            string location = Console.ReadLine(); 
            Thread.Sleep(4000);
            Console.WriteLine("hmmmmm thats interesting " + name + " My great great great great great great great great great great grandma's cousin's dog's brother lived there too!");
            Thread.Sleep(2000);
            Console.WriteLine("what games do you play " + name + "?");
            string games = Console.ReadLine(); 
            Thread.Sleep(2500);
            Console.WriteLine("I have never played " + games + " before " + name + " but I have heard it is a great game!");
            Thread.Sleep(2000);
            Console.WriteLine("What is your favourite food " + name + "?");
            string food = Console.ReadLine(); 
            Thread.Sleep(2000);
            Console.WriteLine("I love " + food + name + " but I prefer Carbon Reduced Petronium Flakes!");
            Thread.Sleep(2000);
            Console.WriteLine("What is your favourite colour " + name + "?");
            string colour = Console.ReadLine(); 
            Thread.Sleep(2000);
            Console.WriteLine("You like " + colour + "? Your pretty weird " + name + "... Lightgoldenrodyellow is the best colour obviously!");
            Thread.Sleep(2000);
            Console.WriteLine("What is your favourite animal " + name + "?");
            string animal = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("I'm not a " + animal + " person " + name);
            Thread.Sleep(2000);
            Console.WriteLine("What is your favourite movie " + name + "?");
            string movie = Console.ReadLine(); 
            Thread.Sleep(2000);
            Console.WriteLine(movie + " REALLY!?! " + name + " you dont seem like the person to watch those movies");
            Thread.Sleep(2000);
            Console.WriteLine("What is your favourite song? " + name + "?");
            string song = Console.ReadLine();  
            Thread.Sleep(2000);
            Console.WriteLine(song + "... thats very boring._. " + name + " I prefer the song 'I'm a little teapot'");
            Thread.Sleep(3000);
            Console.WriteLine("What is your favourite book " + name + "?");
            string book = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine(book + "? " + name + " I prefer the book 'The Very Hungry Caterpillar'");
            Thread.Sleep(2000);
            Console.WriteLine("What is your favourite sport " + name + "?");
            string sport = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine(sport + " is a great sport " + name + " I prefer the sport of sleeping");
            Thread.Sleep(3000);
            Console.WriteLine("Its seems like our time here is up, here is what i have gathered about you");
            Thread.Sleep(2000);
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine("Initialising data");
            Thread.Sleep(2000);
            Console.WriteLine("Name: " + name);
            Thread.Sleep(1500);
            Console.WriteLine("Age: " + age);
            Thread.Sleep(1500);
            Console.WriteLine("Location: " + location);
            Thread.Sleep(1500);
            Console.WriteLine("Likes playing: " + games);
            Thread.Sleep(1500);
            Console.WriteLine("Favourite food is: " + food);
            Thread.Sleep(1500);
            Console.WriteLine("Favourite colour is: " + colour);
            Thread.Sleep(1500);
            Console.WriteLine("Favourite animal is: " + animal);
            Thread.Sleep(1500);
            Console.WriteLine("Favourite movie is: " + movie);
            Thread.Sleep(1500);
            Console.WriteLine("Favourite song is: " + song);
            Thread.Sleep(1500);
            Console.WriteLine("Favourite book is: " + book);
            Thread.Sleep(1500);
            Console.WriteLine("Favourite sport is: " + sport);
            Thread.Sleep(3000);
            Console.WriteLine("Goodbye " + name + " I hope you run me again next time");
            Thread.Sleep(5000);
            Console.WriteLine("Connection Ended");
        }
    }
}
