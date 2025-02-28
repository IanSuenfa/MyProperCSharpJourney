using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class MultipleParameters
    { 
    public static void Example()
        {
            
            Price("James", 270);
            Price("Tom", 320);

            static void Price(string name, double purchase)
            {
                if(purchase >= 300)
                {
                    purchase *= 0.75;

                    
                }
                Console.WriteLine($"{name} has to pay {purchase}");
            }

            

        }
    }


}
