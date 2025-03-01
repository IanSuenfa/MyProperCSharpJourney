using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.Exersise_work
{
    public static class Ride
    {
        public static void Example()
        {
            Console.WriteLine("Welcome to Ride you must be 7 and or over to be able to enter");
            for(int i = 1; i < 14; i++)
            {
                if (i >= 7){
                    Console.WriteLine("Come right inside");
                }


                else if (i < 7){
                    Console.WriteLine("you can't go on this ride come back in", 7 - i, "years");
                }

            }
        }
    }
}
