using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.SoloLearn
{
    public static class DataTypes
    {
        public static void Example()
        {
            Char label = 'a';
            Console.WriteLine(label);
            
            int age = 13;
            Console.WriteLine(age);

            int JPoints = 10;
            Console.WriteLine(JPoints);

            int EPoints = 9;
            Console.WriteLine(EPoints);

            float AppleHeight = 29.4f; //32 bit floating data
            double AppleWeight = 129.2; //64 bit floating data
            decimal AppleTotalAtoms = 100000000000000000000000000m; //128 bit floating data

            Console.WriteLine(AppleTotalAtoms);
            Console.WriteLine(AppleHeight);
            Console.WriteLine(AppleWeight);
        }
    }
}
