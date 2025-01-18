using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work
{
    public class OperatorsAndStrings
    {
        public static void Example()
        {
            Console.WriteLine("Conection initiated");
            Console.WriteLine("Hello there! My name is Milo.");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("how old are you " + name + "?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where do you live " + name + "?");
            string location = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("hmmmmm thats interesting " + name + " My great great great great great great great great great great grandma's cousin's dog's brother lived there too!");
            Console.WriteLine("games do you play " + name + "?");
            string games = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("I have never played " + games + " before " + name + " but I have heard it is a great game!");
            Console.WriteLine("What is your favourite food " + name + "?");
            string food = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("I love " + food + name + " but I prefer oranges!");
            Console.WriteLine("What is your favourite colour " + name + "?");
            string colour = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("You like " + colour + " yout pretty weird " + name + " lightgoldenrodyellow is the best");
            Console.WriteLine("What is your favourite animal " + name + "?");
            string animal = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("I'm not a " + animal + " person " + name);
            Console.WriteLine("What is your favourite movie " + name + "?");
            string movie = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(movie + " REALLY!?! " + name + " you dont seem like the person to watch those movies");
            Console.WriteLine("What is your favourite song? " + name + "?");
            string song = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(song + " thats very boring... " + name + " I prefer the song 'I'm a little teapot'");
            Console.WriteLine("What is your favourite book " + name + "?");
            string book = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(book + "?" + name + " I prefer the book 'The Very Hungry Caterpillar'");
            Console.WriteLine("What is your favourite sport " + name + "?");
            string sport = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(sport + " is a great sport " + name + " I prefer the sport of sleeping");
            Console.WriteLine("Its seems like our time here is up, here is what i have gathered about you");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("Likes playing: " + games);
            Console.WriteLine("Favourite food is: " + food);
            Console.WriteLine("Favourite colour is: " + colour);
            Console.WriteLine("Favourite animal is: " + animal);
            Console.WriteLine("Favourite movie is: " + movie);
            Console.WriteLine("Favourite song is: " + song);
            Console.WriteLine("Favourite book is: " + book);
            Console.WriteLine("Favourite sport is: " + sport);
            Console.WriteLine("Goodbye " + name + " I hope you run me again next time");
            Console.WriteLine("Connection Ended");
        }
    }
}
