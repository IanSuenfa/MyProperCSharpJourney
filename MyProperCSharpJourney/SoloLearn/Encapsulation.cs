using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperCSharpJourney.SoloLearn
{
    public static class Encapsulation
    {
        class BankAccount
        {
            private double balance = 0;
            public void Deposit(double n)
            {
                balance += n;
            }
            public void Withdraw(double n)
            {
                balance -= n;
            }
            public double GetBalance()
            {
                return balance;
            }
        }
        public static void Example()
        {
            BankAccount b = new BankAccount();
            b.Deposit(199.99);
            b.Withdraw(99.99);
            Console.WriteLine(b.GetBalance());
        }
    }
}

