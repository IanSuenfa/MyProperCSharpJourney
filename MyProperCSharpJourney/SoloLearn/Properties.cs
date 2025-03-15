using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class Properties
    {
        class BankBalance
        {
            private double balance = 0;
            public double Balance
            {
                get { return balance; }
                set 
                {
                    if (value >= 0)
                    {
                        balance = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount");
                    }
                }
            }
        }
        public static void Example()
        {
            BankBalance b = new BankBalance();
            b.Balance = 199.99;
            Console.WriteLine(b.Balance);
        }

    }
}
